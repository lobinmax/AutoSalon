SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[СписокФильтров_ТипПривода]
    @Все AS BIT = 1
AS 
BEGIN
	SELECT TOP 100 PERCENT 
        NULL AS Id, 
        CASE WHEN @Все = 0 OR @Все IS NULL THEN NULL ELSE 'Все' END AS Name,
        CAST(0 AS INT) AS Sort
    UNION ALL 
    SELECT TOP 100 PERCENT 
        атп.IdТипПривода AS Id, 
        атп.Наименование AS Name, 
        ROW_NUMBER() OVER (ORDER BY атп.Наименование) AS Sort
    FROM АвтоТипПривода атп
    ORDER BY Sort
END
GO