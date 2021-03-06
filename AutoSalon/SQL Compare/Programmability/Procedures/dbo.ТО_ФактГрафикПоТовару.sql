﻿SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ТО_ФактГрафикПоТовару]
    @UIDТОвара AS UNIQUEIDENTIFIER = NULL,
    @UIDТО AS UNIQUEIDENTIFIER = NULL,
    @ДатаФакта AS DATE = NULL,

    @Function AS INT = 0
AS 
BEGIN

    IF @Function = 0 
    BEGIN
        CREATE TABLE #to
        (
            UIDТО UNIQUEIDENTIFIER NULL,
            UIDТовара UNIQUEIDENTIFIER NULL,
            [Наименование ТО] VARCHAR(300) NULL,
            [Плановая дата] DATE NULL,
            [Фактическая дата] DATE NULL,
            [Стоимость работ] MONEY NULL,
            [Стоимость запчастей] MONEY NULL,
            [Автор записи] VARCHAR(200) NULL,
            [Дата создания] DATETIME NULL,
            Sort INT NULL 
        )
        
        INSERT #to
        SELECT 
            тф.UIDТО, 
            тф.UIDТовара, 
            тф.ТО_Наименование, 
            тф.ДатаПлан AS [Плановая дата], 
            тф.ДатаФакт AS [Фактическая дата], 
            (
              SELECT SUM(тфр.Стоимость) 
              FROM ТО_ФактРаботы тфр 
              WHERE тфр.UIDТО = тф.UIDТО
            ) AS [Стоимость работ],
            (
              SELECT (SUM(тфз.Стоимость) * тфз.Количество) 
              FROM ТО_ФактЗапчасти тфз 
              WHERE тфз.UIDТО = тф.UIDТО 
              GROUP BY тфз.Количество
            ) AS [Стоимость запчастей],
            dbo.ШтатПолучитьФИО(тф.UIDАвтора) AS [Автор записи], 
            тф.ДатаСоздания AS [Дата создания],
            ROW_NUMBER() OVER (ORDER BY тф.ДатаПлан) AS Sort
        FROM ТО_Факт тф
        WHERE тф.UIDТовара = @UIDТОвара  

        INSERT #to (UIDТО, UIDТовара, [Наименование ТО], [Стоимость работ], [Стоимость запчастей], Sort)
        VALUES 
        (
            '00000000-0000-0000-0000-000000000000',
            '00000000-0000-0000-0000-000000000000',
            'Итого', 
            (SELECT SUM(t.[Стоимость работ]) FROM #to t), 
            (SELECT SUM(t.[Стоимость запчастей]) FROM #to t),
            99999
        )
    
        SELECT 
            t.UIDТО, 
            t.UIDТовара, 
            t.[Наименование ТО], 
            t.[Плановая дата], 
            t.[Фактическая дата],
            FORMAT(CAST(ISNULL(t.[Стоимость работ], 0.00) AS MONEY), 'C') AS [Стоимость работ], 
            FORMAT(CAST(ISNULL(t.[Стоимость запчастей], 0.00) AS MONEY), 'C') AS [Стоимость запчастей], 
            t.[Автор записи] 
        FROM #to t 
        ORDER BY t.Sort
    END 

    IF @Function = 1 
    BEGIN 
        UPDATE ТО_Факт 
        SET ДатаФакт = @ДатаФакта 
        WHERE UIDТО = @UIDТО           
    END 

END 
GO