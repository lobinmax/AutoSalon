SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[СписокФильтров_МаркиАвто]
    @Все AS BIT = 1
AS 
BEGIN
	SELECT TOP 100 PERCENT 
        NULL AS UID, 
        CASE WHEN @Все = 0 OR @Все IS NULL THEN NULL ELSE 'Все' END AS Name, 
        CAST(0 AS INT) AS Sort
    UNION ALL 
    SELECT TOP 100 PERCENT 
        ам.UIDМарки AS UID, 
        ам.Наименование AS Name, 
        ROW_NUMBER() OVER (ORDER BY ам.Наименование) AS Sort
    FROM АвтоМарки ам
    ORDER BY Sort
END
GO