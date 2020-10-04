SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ТО_ФактРаботы_SIUD]
    @UIDТО AS UNIQUEIDENTIFIER = NULL,
    @UIDРаботы AS UNIQUEIDENTIFIER = NULL,
    @IdВидаРемонта INT = NULL,
    @Стоимость AS MONEY = NULL, 
    
    @Function AS INT = 0
AS 
BEGIN 
    -- для формы
    IF @Function = 0
    BEGIN
        SELECT 
            тфр.UIDТО, 
            тфр.UIDРаботы, 
            твр.Наименование AS [Наименование работы], 
            тфр.Стоимость AS [Стоимость работы], 
            CAST(ISNULL(SUM(тфз.Стоимость), 0.00) AS MONEY) AS [Стоимость запчастей],
            тфр.ДатаСоздания AS [Дата создания], 
            dbo.ШтатПолучитьФИО(тфр.UIDАвтора) AS [Автор записи]
        FROM ТО_ФактРаботы тфр
        INNER JOIN ТО_ВидыРемонта твр 
            ON тфр.IdВидаРемонта = твр.IdВидаРемонта
        LEFT JOIN ТО_ФактЗапчасти тфз
            ON тфр.UIDРаботы = тфз.UIDРаботы
        WHERE (@UIDТО IS NULL OR тфр.UIDТО = @UIDТО)
        GROUP BY тфр.UIDТО, 
                 тфр.UIDРаботы, 
                 твр.Наименование, 
                 тфр.Стоимость, 
                 тфр.ДатаСоздания, 
                 dbo.ШтатПолучитьФИО(тфр.UIDАвтора)
    END

    -- для select
    IF @Function = 1
    BEGIN
        SELECT 
            тфр.UIDРаботы, 
            тфр.UIDТО, 
            тфр.IdВидаРемонта, 
            тфр.Стоимость, 
            тфр.ДатаСоздания, 
            тфр.UIDАвтора
        FROM ТО_ФактРаботы тфр
        WHERE тфр.UIDТО = @UIDТО
    END

    -- для insert
    IF @Function = 2
    BEGIN
        BEGIN TRANSACTION
        
        SET @UIDРаботы = NEWID()
        INSERT ТО_ФактРаботы (UIDРаботы, UIDТО, IdВидаРемонта, Стоимость)
        VALUES (@UIDРаботы, @UIDТО, @IdВидаРемонта, @Стоимость)

        IF (@@ERROR != 0
            OR @@TRANCOUNT = 0)
        BEGIN
            IF @@TRANCOUNT > 0
                ROLLBACK TRANSACTION
        END
        IF @@TRANCOUNT != 0
        BEGIN
            COMMIT TRANSACTION
        END
    END

    -- для update
    IF @Function = 3
    BEGIN
        BEGIN TRANSACTION
        
        UPDATE ТО_ФактРаботы 
        SET IdВидаРемонта = @IdВидаРемонта
           ,Стоимость = @Стоимость 
        WHERE UIDРаботы = @UIDРаботы

        IF (@@ERROR != 0
            OR @@TRANCOUNT = 0)
        BEGIN
            IF @@TRANCOUNT > 0
                ROLLBACK TRANSACTION
        END
        IF @@TRANCOUNT != 0
        BEGIN
            COMMIT TRANSACTION
        END
    END

    -- delete
    IF @Function = 4
    BEGIN
        BEGIN TRANSACTION
        
        DELETE ТО_ФактЗапчасти
        WHERE UIDРаботы = @UIDРаботы

        DELETE ТО_ФактРаботы
        WHERE UIDРаботы = @UIDРаботы

        IF (@@ERROR != 0
            OR @@TRANCOUNT = 0)
        BEGIN
            IF @@TRANCOUNT > 0
                ROLLBACK TRANSACTION
        END
        IF @@TRANCOUNT != 0
        BEGIN
            COMMIT TRANSACTION
        END
    END

    IF @Function IN (2, 3)
    BEGIN
        SELECT
            @UIDРаботы AS id
    END

END 
GO