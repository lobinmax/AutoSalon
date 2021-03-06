﻿SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[Заказы_SIUD]
    @UIDЗаказа AS UNIQUEIDENTIFIER = NULL,
    @UIDТовара AS UNIQUEIDENTIFIER = NULL,
    @СтоимостьАвто AS MONEY = NULL,
    @UIDКлиента AS UNIQUEIDENTIFIER = NULL,
    @IdСтатусаЗаказа AS TINYINT = NULL,
    @СуммаОплаты AS MONEY = NULL,
    @СформироватьГрафикТО AS BIT = 0,
    @Function AS INT = 0
AS 
BEGIN
	
    -- для формы
    IF @Function = 0 
    BEGIN   
        SELECT з.UIDЗаказа
              ,з.UIDТовара
              ,'№ ' + з.НомерЗаказа + ' от ' + CONVERT(VARCHAR, з.ДатаЗаказа, 104) + ' г.' AS [Номер заказа]
              ,dbo.КлиентПолучитьФИО(з.UIDКлиента) AS [ФИО клиента]
              ,dbo.АвтоПолучитьСтрокой(з.UIDТовара) AS [Информация об авто]
              ,FORMAT(з.СтоимостьАвто, 'N2') AS [Цена авто]
              ,FORMAT(з.СуммаОплаты, 'N2') AS [Сумма оплаты]
              ,CAST(((з.СуммаОплаты / з.СтоимостьАвто) * 100) AS VARCHAR(10)) + '%' AS [Доля оплаты]
              ,зс.Наименование AS [Статус заказа]
              ,з.ДатаСоздания AS [Дата создания]
              ,dbo.ШтатПолучитьФИОкратко(з.UIDАвтора) AS [Автор записи]
              ,з.ДатаИзменения AS [Дата изменения]
              ,dbo.ШтатПолучитьФИОкратко(з.UIDИзменяющего) AS [Автор изменений]
              ,CASE WHEN NOT EXISTS(SELECT * FROM ТО_Факт тф WHERE тф.UIDТовара = з.UIDТовара) THEN 'НЕ сформирован' ELSE 'Сформирован' END AS [График ТО]
        FROM Заказы з
        INNER JOIN ЗаказыСтатусы зс 
            ON з.IdСтатусаЗаказа = зс.IdСтатусЗаказа
    END 

    -- для select
    IF @Function = 1
    BEGIN
        SELECT з.UIDЗаказа
              ,з.UIDТовара
              ,з.СтоимостьАвто AS [Стоимость]
              ,з.СуммаОплаты
              ,з.UIDКлиента
              ,'№ ' + з.НомерЗаказа + ' от ' + CONVERT(VARCHAR, з.ДатаЗаказа, 104) + ' г.' AS [НомерЗаказа]
              ,з.ДатаЗаказа
              ,з.IdСтатусаЗаказа
              ,з.СуммаОплаты
              ,CASE WHEN NOT EXISTS(SELECT * FROM ТО_Факт тф WHERE тф.UIDТовара = з.UIDТовара) THEN 0 ELSE 1 END AS [СформированГрафикТО]
        FROM Заказы з
        WHERE з.UIDЗаказа = @UIDЗаказа 
    END 

     -- для insert
    IF @Function = 2
    BEGIN
        BEGIN TRANSACTION
        
        SET @UIDЗаказа = NEWID()
        INSERT INTO Заказы 
        (
            UIDЗаказа,
            UIDТовара, 
            СтоимостьАвто, 
            UIDКлиента, 
            НомерЗаказа, 
            ДатаЗаказа, 
            IdСтатусаЗаказа, 
            СуммаОплаты
        )
        VALUES 
        (
            @UIDЗаказа,
            @UIDТовара, 
            @СтоимостьАвто, 
            @UIDКлиента, 
            dbo.ЗаказыГенераторНомера(), 
            dbo.DtТекущаяДата(), 
            @IdСтатусаЗаказа, 
            @СуммаОплаты
        )

        IF (@@ERROR != 0 OR @@TRANCOUNT = 0) 
        BEGIN 
            IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION   
        END
        IF @@TRANCOUNT != 0 BEGIN COMMIT TRANSACTION END
    END 

    -- для update
    IF @Function = 3
    BEGIN
        BEGIN TRANSACTION
        
        UPDATE Заказы 
        SET UIDТовара = @UIDТовара
           ,UIDКлиента = @UIDКлиента
           ,IdСтатусаЗаказа = @IdСтатусаЗаказа
           ,СуммаОплаты = @СуммаОплаты
           ,ДатаИзменения = dbo.DtТекущаяДатаВремя()
           ,UIDИзменяющего = dbo.ШтатПолучитьUIDСотрудника()
        WHERE UIDЗаказа = @UIDЗаказа

        IF (@@ERROR != 0 OR @@TRANCOUNT = 0) 
        BEGIN 
            IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION   
        END
        IF @@TRANCOUNT != 0 BEGIN COMMIT TRANSACTION END 
    END 
    
    -- delete
    IF @Function = 4
    BEGIN
        BEGIN TRANSACTION

        DELETE FROM Заказы
        WHERE UIDЗаказа = @UIDЗаказа

        DELETE ТО_Факт
        WHERE UIDТовара = @UIDТовара

        IF (@@ERROR != 0 OR @@TRANCOUNT = 0) 
        BEGIN 
            IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION   
        END
        IF @@TRANCOUNT != 0 BEGIN COMMIT TRANSACTION END   	
        END 

    IF @Function IN (2, 3) 
    BEGIN 
        UPDATE ГаражАвто 
        SET IdСтатусАвто = (
                                SELECT TOP (1) гса.IdСтатусАвто 
                                FROM ГаражСтатусАвто гса 
                                WHERE гса.Наименование = 'Продано'
                           ) 
        WHERE UIDТовара = @UIDТовара
        
        IF (@СформироватьГрафикТО = 1 AND NOT EXISTS(SELECT * FROM ТО_Факт тф WHERE тф.UIDТовара = @UIDТовара))
        BEGIN
        	EXEC ТО_СоставитьГрафик @UIDТовара
        END

        SELECT @UIDЗаказа AS id 
    END 
END
GO