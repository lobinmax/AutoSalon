SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[СписокФильтров_ТипРуля]
    @Все AS BIT = 1
AS 
BEGIN
	SELECT TOP 100 PERCENT 
        NULL AS Id, 
        CASE WHEN @Все = 0 OR @Все IS NULL THEN NULL ELSE 'Все' END AS Name,
        CAST(0 AS INT) AS Sort
    UNION ALL 
    SELECT TOP 100 PERCENT 
        атр.IdТипРуля AS Id, 
        атр.Наименование AS Name, 
        ROW_NUMBER() OVER (ORDER BY атр.Наименование) AS Sort
    FROM АвтоТипРуля атр
    ORDER BY Sort
END
GO