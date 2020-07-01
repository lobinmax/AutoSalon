SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ЯдроНастройкаБазыДанных]
AS 
BEGIN
    SET NOCOUNT ON
    SET XACT_ABORT ON

    BEGIN TRANSACTION
    
    -- проверка настроена ли база
	IF NOT EXISTS (SELECT * FROM dbo.ЯдроКонстанты AS як WHERE як.Наименование = 'База данных настроена')
    BEGIN
        -- пол
        IF NOT EXISTS (SELECT * FROM dbo.КлиентыПол AS кп)
        BEGIN
            -- настройка полов
            SET IDENTITY_INSERT КлиентыПол ON
            INSERT КлиентыПол (IdПола, Наименование)
            VALUES (0, 'Женский'), (1, 'Мужской')
            SET IDENTITY_INSERT КлиентыПол OFF        	
        END

        -- Тип руля
        IF NOT EXISTS (SELECT * FROM dbo.АвтоТипРуля AS атр)
        BEGIN
            -- настройка полов
            INSERT dbo.АвтоТипРуля (Наименование)
            VALUES ('Левый'), ('Правый')      	
        END
    	
        -- Тип КПП
        IF NOT EXISTS(SELECT * FROM АвтоТипКПП атк)
        BEGIN
        	INSERT АвтоТипКПП (Наименование, [Наименование сокр.])
            VALUES ('Автоматическая', 'АКПП'), ('Механическая', 'МКПП')
        END

        -- Тип привода
        IF NOT EXISTS(SELECT * FROM АвтоТипПривода атп)
        BEGIN
        	INSERT АвтоТипПривода (Наименование)
            VALUES ('Передний'), ('Задний'), ('Полный')
        END

        -- Тип топлива
        IF NOT EXISTS(SELECT * FROM АвтоТипТоплива атт)
        BEGIN
        	INSERT АвтоТипТоплива (Наименование)
            VALUES ('Бензин'), ('Газ'), ('Дизель')
        END

        -- Страны
        IF NOT EXISTS(SELECT * FROM Страны с)
        BEGIN
        	INSERT Страны (UIDСтраны, Наименование, [Наименование сокр.])
            VALUES (DEFAULT, 'Россия', 'RU'),
                   (DEFAULT, 'Япония', 'JP'),
                   (DEFAULT, 'Болгария', 'BG'),
                   (DEFAULT, 'Германия', 'DE'),
                   (DEFAULT, 'США', 'US')     
        END

        -- Должности
        IF NOT EXISTS (SELECT * FROM dbo.ШтатДолжности AS шд WHERE шд.Наименование = 'Системный администратор')
        BEGIN
            INSERT dbo.ШтатДолжности (Наименование, СервернаяРоль)
            VALUES('Системный администратор', 'SalonWorker')
        END
        IF NOT EXISTS (SELECT * FROM dbo.ШтатДолжности AS шд WHERE шд.Наименование = 'Управляющий')
        BEGIN
            INSERT dbo.ШтатДолжности (Наименование, СервернаяРоль)
            VALUES ('Управляющий', 'SalonWorker')
        END
        IF NOT EXISTS (SELECT * FROM dbo.ШтатДолжности AS шд WHERE шд.Наименование = 'Кассир')
        BEGIN
            INSERT dbo.ШтатДолжности (Наименование, СервернаяРОль)
            VALUES ('Кассир', 'SalonWorker')
        END
        IF NOT EXISTS (SELECT * FROM dbo.ШтатДолжности AS шд WHERE шд.Наименование = 'Старший менеджер')
        BEGIN
            INSERT dbo.ШтатДолжности (Наименование, СервернаяРоль)
            VALUES ('Старший менеджер', 'SalonWorker')
        END
        IF NOT EXISTS (SELECT * FROM dbo.ШтатДолжности AS шд WHERE шд.Наименование = 'Консультант')
        BEGIN
            INSERT dbo.ШтатДолжности (Наименование, СервернаяРоль)
            VALUES('Консультант', 'SalonWorker')
        END

        IF NOT EXISTS (SELECT * FROM dbo.ШтатСотрудники AS шс WHERE шс.Логин = 'sa')
        BEGIN
            -- добавить сисадмина
            INSERT INTO dbo.ШтатСотрудники 
            (
                UIDСотрудника,
                Логин, 
                Фамилия, 
                Имя, 
                Отчество, 
                [Дата рождения], 
                IdДолжности, 
                ДатаСоздания, 
                ДатаИзменения, 
                UIDАвтора, 
                UIDИзменяющего, 
                IdПола
            )
            VALUES 
            (
                '4EF62F54-D8B0-4911-A3C3-C3D640B4BDA9',
                'sa', 
                'Системный администратор', 
                '', 
                '', 
                '19000101', 
                (SELECT шд.IdДолжности FROM dbo.ШтатДолжности AS шд WHERE шд.Наименование = 'Системный администратор'), 
                GETDATE(), 
                GETDATE(), 
                '4EF62F54-D8B0-4911-A3C3-C3D640B4BDA9', 
                '4EF62F54-D8B0-4911-A3C3-C3D640B4BDA9',  
                1
            )           	
        END
        
        IF NOT EXISTS(SELECT * FROM ГаражСтатусАвто гса WHERE гса.Наименование = 'В продаже')
        BEGIN
            SET IDENTITY_INSERT ГаражСтатусАвто ON
            INSERT ГаражСтатусАвто (IdСтатусАвто, Наименование)
            VALUES (0, 'В продаже')
            SET IDENTITY_INSERT ГаражСтатусАвто OFF    
        END
        IF NOT EXISTS(SELECT * FROM ГаражСтатусАвто гса WHERE гса.Наименование = 'Продано')
        BEGIN
            SET IDENTITY_INSERT ГаражСтатусАвто ON
            INSERT ГаражСтатусАвто (IdСтатусАвто, Наименование)
            VALUES (1, 'Продано')
            SET IDENTITY_INSERT ГаражСтатусАвто OFF            	
        END
        IF NOT EXISTS(SELECT * FROM ГаражСтатусАвто гса WHERE гса.Наименование = 'Ожидает поступления')
        BEGIN
            SET IDENTITY_INSERT ГаражСтатусАвто ON
            INSERT ГаражСтатусАвто (IdСтатусАвто, Наименование)
            VALUES (2, 'Ожидает поступления')
            SET IDENTITY_INSERT ГаражСтатусАвто OFF            	
        END
        IF NOT EXISTS(SELECT * FROM ГаражСтатусАвто гса WHERE гса.Наименование = 'Предзаказ')
        BEGIN
            SET IDENTITY_INSERT ГаражСтатусАвто ON
            INSERT ГаражСтатусАвто (IdСтатусАвто, Наименование)
            VALUES (3, 'Предзаказ')
            SET IDENTITY_INSERT ГаражСтатусАвто OFF            	
        END

        -- база данных настроена
        INSERT INTO dbo.ЯдроКонстанты (Наименование, Значение)
        VALUES ('База данных настроена', CAST(1 AS BIT))
    END
    
    IF (@@ERROR != 0 OR @@TRANCOUNT = 0) 
    BEGIN 
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION   
    END
    IF @@TRANCOUNT != 0 BEGIN COMMIT TRANSACTION END 
END
GO