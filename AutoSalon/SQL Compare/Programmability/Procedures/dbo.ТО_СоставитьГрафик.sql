SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ТО_СоставитьГрафик]
    @UIDТовара UNIQUEIDENTIFIER
AS 
BEGIN

    DECLARE @ДатаПродажи AS DATE = dbo.DtТекущаяДата()
    DECLARE @НаименованиеТО AS VARCHAR(150)
    DECLARE @СрокГод AS INT 
    DECLARE @СрокМесяц AS INT 
    DECLARE Курсор CURSOR FOR 
        SELECT тг.Наименование, 
               тг.СрокГод, 
               тг.СрокМесяц
        FROM ТО_График тг
    
    OPEN Курсор
    FETCH NEXT FROM Курсор INTO @НаименованиеТО, @СрокГод, @СрокМесяц
    WHILE @@fetch_status = 0
    BEGIN
        DECLARE @ДатаФакт AS DATE
        SET @ДатаФакт = DATEADD(MONTH, @СрокМесяц, DATEADD(YEAR, @СрокГод, @ДатаПродажи))

        INSERT INTO ТО_Факт (UIDТО, UIDТовара, ТО_Наименование, ДатаПлан, ДатаФакт)
        VALUES (NEWID(), @UIDТовара, @НаименованиеТО, @ДатаФакт, NULL)

        FETCH NEXT FROM Курсор INTO @НаименованиеТО, @СрокГод, @СрокМесяц
    END
    
    CLOSE Курсор
    DEALLOCATE Курсор
END 
GO