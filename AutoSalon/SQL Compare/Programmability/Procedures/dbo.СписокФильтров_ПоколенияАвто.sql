SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[СписокФильтров_ПоколенияАвто]
    @UIDМарки AS UNIQUEIDENTIFIER = NULL,
    @UIDМодели AS UNIQUEIDENTIFIER = NULL, 
    @Все AS BIT = 1
AS 
BEGIN
	SELECT TOP 100 PERCENT 
        NULL AS UID, 
        CASE WHEN @Все = 0 OR @Все IS NULL THEN NULL ELSE 'Все' END AS Name,
        CAST(0 AS INT) AS Sort
    UNION ALL 
    SELECT TOP 100 PERCENT 
        ап.UIDПоколения AS UID, 
        ап.Наименование AS Name, 
        ROW_NUMBER() OVER (ORDER BY ап.Наименование) AS Sort
    FROM АвтоПоколение ап
    WHERE (ап.UIDМарки = @UIDМарки)
       AND (ап.UIDМодели = @UIDМодели)
    ORDER BY Sort
END
GO