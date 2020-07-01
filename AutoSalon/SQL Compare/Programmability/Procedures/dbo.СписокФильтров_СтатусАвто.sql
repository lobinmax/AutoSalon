SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[СписокФильтров_СтатусАвто]
    @Все AS BIT = 1
AS 
BEGIN
	SELECT TOP 100 PERCENT 
        NULL AS Id, 
        CASE WHEN @Все = 0 OR @Все IS NULL THEN NULL ELSE 'Все' END AS Name,
        CAST(0 AS INT) AS Sort
    UNION ALL 
    SELECT TOP 100 PERCENT 
        гса.IdСтатусАвто AS Id, 
        гса.Наименование AS Name, 
        ROW_NUMBER() OVER (ORDER BY гса.Наименование) AS Sort
    FROM ГаражСтатусАвто гса
    ORDER BY Sort
END
GO