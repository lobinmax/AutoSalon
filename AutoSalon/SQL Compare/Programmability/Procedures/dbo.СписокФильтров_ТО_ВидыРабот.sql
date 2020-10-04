SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[СписокФильтров_ТО_ВидыРабот] 
    @Все AS BIT = 1
AS
BEGIN
    SELECT TOP 100 PERCENT
        NULL AS Id
       ,CASE
            WHEN @Все = 0 OR
                @Все IS NULL THEN NULL
            ELSE 'Все'
        END AS Name
       ,CAST(0 AS INT) AS Sort
    UNION ALL
    SELECT TOP 100 PERCENT
        твр.IdВидаРемонта AS Id
       ,твр.Наименование AS Name
       ,ROW_NUMBER() OVER (ORDER BY твр.Наименование) AS Sort
    FROM ТО_ВидыРемонта твр
    ORDER BY Sort
END
GO