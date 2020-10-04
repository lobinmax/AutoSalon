SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ТО_ФактЗапчасти_SIUD]
    @UIDРаботы UNIQUEIDENTIFIER = NULL,
    @UIDЗапчасти UNIQUEIDENTIFIER = NULL,
    @UIDТО UNIQUEIDENTIFIER = NULL, 
    @IdЗапчасти INT = NULL, 
    @Количество INT = NULL, 
    @Стоимость MONEY = NULL,

    @Function INT = NULL
AS
BEGIN
    -- для формы
    IF @Function = 0
    BEGIN
        SELECT 
            тфз.UIDЗапчасти, 
            тфз.UIDРаботы, 
            тфз.UIDТО, 
            тз.Наименование AS [Наименование расходника], 
            тфз.Количество AS [Кол-во], 
            тфз.Стоимость AS [Стоимость], 
            тфз.ДатаСоздания AS [Дата создания], 
            dbo.ШтатПолучитьФИО(тфз.UIDАвтора) AS [Автор записи]
        FROM ТО_ФактЗапчасти тфз
        INNER JOIN ТО_Запчасти тз 
            ON тфз.IdЗапчасти = тз.IdЗапчасти
        WHERE тфз.UIDРаботы = @UIDРаботы
    END

    -- для select
    IF @Function = 1
    BEGIN
        SELECT 
            тфз.UIDЗапчасти, 
            тфз.UIDРаботы, 
            тфз.UIDТО, 
            тфз.IdЗапчасти, 
            тфз.Количество, 
            тфз.Стоимость
        FROM ТО_ФактЗапчасти тфз
        WHERE тфз.UIDРаботы = @UIDРаботы
    END

    -- для insert
    IF @Function = 2
    BEGIN
        BEGIN TRANSACTION
        
        SET @UIDЗапчасти = NEWID()
        INSERT ТО_ФактЗапчасти 
        (
            UIDЗапчасти, 
            UIDРаботы, 
            UIDТО, 
            IdЗапчасти, 
            Количество, 
            Стоимость
        )
        VALUES 
        (
            @UIDЗапчасти, 
            @UIDРаботы, 
            @UIDТО, 
            @IdЗапчасти, 
            @Количество, 
            @Стоимость
        ) 

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

        UPDATE ТО_ФактЗапчасти 
        SET UIDРаботы = @UIDРаботы
           ,UIDТО = @UIDТО
           ,IdЗапчасти = @IdЗапчасти
           ,Количество = @Количество
           ,Стоимость = @Стоимость
        WHERE UIDЗапчасти = @UIDЗапчасти

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
        WHERE @UIDЗапчасти = @UIDЗапчасти

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
        SELECT @UIDЗапчасти AS id
    END

END  
GO