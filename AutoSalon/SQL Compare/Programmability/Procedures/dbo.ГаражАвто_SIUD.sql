SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ГаражАвто_SIUD]
    @UIDТовара AS UNIQUEIDENTIFIER = NULL,
    @UIDМарки AS UNIQUEIDENTIFIER = NULL,
    @UIDМодели AS UNIQUEIDENTIFIER = NULL,
    @UIDПоколения AS UNIQUEIDENTIFIER = NULL,
    @ОбновитьСтатистику AS BIT = 1,
    @Стоимость AS MONEY = 0,
    @СтоимостьДо AS MONEY = 10000000,
    @IdСтатусАвто AS TINYINT = NULL,
    @IdТипТоплива AS TINYINT = NULL,
    @IdТипПривода AS TINYINT = NULL,
    @IdТипРуля AS TINYINT = NULL,
    @IdТипКПП AS TINYINT = NULL,
    @IdТипКузова AS TINYINT = NULL,
    @ГодВыпуска AS INT = 1900,
    @ГодВыпускаДо AS INT = 3020,
    @Пробег AS INT = 0,
    @ПробегДо AS INT = 1000000,
    @ЦветRGB AS VARCHAR(20) = NULL,
    @VIN AS VARCHAR(30) = NULL,
    @ОбъемДвигателя AS DECIMAL = 0.00,
    @ОбъемДвигателяДо AS DECIMAL = 10.00,
    @МощностьДвигателя AS INT = 0,
    @МощностьДвигателяДо AS INT = 1500,
    @НомерКузова AS VARCHAR(50) = NULL,
    @СтранаИзготовитель AS BIT = NULL,
    @БезПробега AS BIT = NULL,
    @Function AS INT = 0

AS 
BEGIN
    DECLARE @UIDСтоимости AS UNIQUEIDENTIFIER

    -- для формы
    IF @Function = 0 
    BEGIN
         SELECT
            га.UIDТовара
           ,dbo.ГаражПолучитьЦенуАвтоUID(га.UIDТовара) AS UIDСтоимости
           ,ам.Наименование AS Марка
           ,ам1.Наименование AS Модель
           ,ап.Наименование AS Поколение
           ,га.ГодВыпуска + ' г.' AS Год
           ,FORMAT(га.Пробег, 'N0') + ' км' AS Пробег
           ,dbo.ГаражПолучитьЦенуАвто(га.UIDТовара) AS Цена
           ,га.ЦветRGB AS [Цвет авто]
           ,CAST(га.ОбъемДвигателя AS VARCHAR(5)) + ' л.' AS [Объем двигателя]
           ,CAST(га.МощностьДвигателя AS VARCHAR(10)) + ' л.с.' AS Мощность
           ,атк.Наименование AS [Тип кузова]
           ,атк1.[Наименование сокр.] AS КПП
           ,атр.Наименование AS Руль
           ,атт.Наименование AS Топливо
           ,атп.Наименование AS Привод
           ,га.VIN
           ,га.НомерКузова AS [Номер кузова]
           ,гса.Наименование AS Статус
           ,га.ДатаСоздания AS Добавлено
           ,dbo.ШтатПолучитьФИОкратко(га.UIDАвтора) AS Автор
        FROM dbo.ГаражАвто га
        INNER JOIN dbo.АвтоМарки ам
            ON га.UIDМарки = ам.UIDМарки
        INNER JOIN dbo.АвтоМодели ам1
            ON га.UIDМодели = ам1.UIDМодели
        INNER JOIN dbo.АвтоПоколение ап
            ON га.UIDПоколения = ап.UIDПоколения
        INNER JOIN dbo.ГаражСтатусАвто гса
            ON га.IdСтатусАвто = гса.IdСтатусАвто
        INNER JOIN dbo.АвтоТипТоплива атт
            ON га.IdТипТоплива = атт.IdТипТоплива
        INNER JOIN dbo.АвтоТипПривода атп
            ON га.IdТипПривода = атп.IdТипПривода
        INNER JOIN dbo.АвтоТипКузова атк
            ON ап.IdТипКузова = атк.IdТипКузова
        INNER JOIN dbo.АвтоТипРуля атр
            ON га.IdТипРуля = атр.IdТипРуля
        INNER JOIN dbo.АвтоТипКПП атк1
            ON га.IdТипКПП = атк1.IdТипКПП
        INNER JOIN Страны с 
            ON ам.UIDСтранаПроизводитель = с.UIDСтраны
        WHERE (@UIDМарки IS NULL OR га.UIDМарки = @UIDМарки)
            AND (@UIDМодели IS NULL OR га.UIDМодели = @UIDМодели)
            AND (@UIDПоколения IS NULL OR га.UIDПоколения = @UIDПоколения)
            AND ((@Стоимость IS NULL OR @СтоимостьДо IS NULL) OR 
                dbo.ГаражПолучитьЦенуАвто(га.UIDТовара) BETWEEN @Стоимость AND @СтоимостьДо)
            AND ((@Пробег IS NULL OR @ПробегДо IS NULL) OR 
                га.Пробег BETWEEN @Пробег AND @ПробегДо)
            AND ((@ГодВыпуска IS NULL OR @ГодВыпускаДо IS NULL) OR 
                га.ГодВыпуска BETWEEN @ГодВыпуска AND @ГодВыпускаДо)
            AND ((@ОбъемДвигателя IS NULL OR @ОбъемДвигателяДо IS NULL) OR 
                га.ОбъемДвигателя BETWEEN @ОбъемДвигателя AND @ОбъемДвигателяДо)
            AND ((@МощностьДвигателя IS NULL OR @МощностьДвигателяДо IS NULL) OR 
                га.МощностьДвигателя BETWEEN @МощностьДвигателя AND @МощностьДвигателяДо)
            AND (@IdТипТоплива IS NULL OR га.IdТипТоплива = @IdТипТоплива)
            AND (@IdТипПривода IS NULL OR га.IdТипПривода = @IdТипПривода)
            AND (@IdТипКузова IS NULL OR ап.IdТипКузова = @IdТипКузова)
            AND (@IdТипРуля IS NULL OR га.IdТипРуля = @IdТипРуля)
            AND (@IdТипКПП IS NULL OR га.IdТипКПП = @IdТипКПП)
            AND (@СтранаИзготовитель IS NULL OR CASE WHEN с.[Наименование сокр.] = 'RU' THEN 0 ELSE 1 END = @СтранаИзготовитель)
            AND (@БезПробега IS NULL OR @БезПробега = 0 OR га.Пробег = 0)
            AND (@ЦветRGB IS NULL OR га.ЦветRGB = @ЦветRGB)
        ORDER BY ам.Наименование, ам1.Наименование, ап.Наименование

    END 

    -- для select
    IF @Function = 1
    BEGIN
        SELECT га.UIDТовара, 
               га.UIDМарки, 
               га.UIDМодели, 
               га.UIDПоколения, 
               га.UIDСтоимости,
               dbo.ГаражПолучитьЦенуАвто(га.UIDТовара) AS Стоимость, 
               га.IdСтатусАвто, 
               га.IdТипТоплива, 
               га.IdТипПривода, 
               га.IdТипРуля, 
               га.IdТипКПП, 
               га.ГодВыпуска, 
               га.Пробег, 
               га.ЦветRGB, 
               га.VIN, 
               га.ОбъемДвигателя, 
               га.МощностьДвигателя,
               га.НомерКузова 
        FROM ГаражАвто га
        WHERE га.UIDТовара = @UIDТовара

    END 

    -- для insert
    IF @Function = 2
    BEGIN
        BEGIN TRANSACTION
        SET @UIDТовара = NEWID()
        SET @UIDСтоимости = NEWID()
--        SET @IdСтатусАвто = (SELECT гса.IdСтатусАвто 
--                             FROM ГаражСтатусАвто гса 
--                             WHERE гса.Наименование LIKE '%В продаже%')
--
--        IF (@IdСтатусАвто IS NULL)
--        BEGIN
--            RAISERROR('Не найден подходящий статус, указывающий что автомобиль в продаже', 16,1)
--        	ROLLBACK TRANSACTION  
--            RETURN
--        END

        INSERT ГаражАвто 
        (
            UIDТовара, 
            UIDМарки, 
            UIDМодели, 
            UIDПоколения, 
            UIDСтоимости, 
            IdСтатусАвто, 
            IdТипТоплива, 
            IdТипПривода,  
            IdТипРуля, 
            IdТипКПП, 
            ГодВыпуска, 
            Пробег, 
            ЦветRGB, 
            VIN, 
            ОбъемДвигателя, 
            МощностьДвигателя, 
            НомерКузова
        )
        VALUES 
        (         
            @UIDТовара, 
            @UIDМарки, 
            @UIDМодели, 
            @UIDПоколения, 
            @UIDСтоимости, 
            @IdСтатусАвто, 
            @IdТипТоплива, 
            @IdТипПривода,  
            @IdТипРуля, 
            @IdТипКПП, 
            @ГодВыпуска, 
            @Пробег, 
            @ЦветRGB,
            @VIN, 
            @ОбъемДвигателя, 
            @МощностьДвигателя, 
            @НомерКузова
        )

        INSERT ГаражСтоимостьАвто 
        (
            UIDСтоимостиАвто, 
            UIDТовара, 
            Стоимость, 
            ДатаСтоимости
        )
        VALUES 
        (
            @UIDСтоимости, 
            @UIDТовара, 
            @Стоимость, 
            dbo.DtТекущаяДатаВремя()
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
        
        IF (dbo.ГаражПолучитьЦенуАвто(@UIDТовара) != @Стоимость AND @ОбновитьСтатистику = 1)
        BEGIN
            SET @UIDСтоимости = NEWID()
            INSERT ГаражСтоимостьАвто 
            (
                UIDСтоимостиАвто, 
                UIDТовара, 
                Стоимость, 
                ДатаСтоимости
            )
            VALUES 
            (
                @UIDСтоимости, 
                @UIDТовара, 
                @Стоимость, 
                dbo.DtТекущаяДатаВремя()
            )
        END 
        ELSE BEGIN
            SET @UIDСтоимости = dbo.ГаражПолучитьЦенуАвтоUID(@UIDТовара)

            UPDATE ГаражСтоимостьАвто 
            SET UIDТовара = @UIDТовара
               ,Стоимость = @Стоимость
               ,ДатаСтоимости = dbo.DtТекущаяДатаВремя()
               ,ДатаИзменения = dbo.DtТекущаяДатаВремя()
               ,UIDИзменяющего = dbo.ШтатПолучитьUIDСотрудника()
            WHERE UIDСтоимостиАвто = @UIDСтоимости;      
        END 

        UPDATE ГаражАвто 
        SET UIDМарки = @UIDМарки
           ,UIDМодели = @UIDМодели
           ,UIDПоколения = @UIDПоколения
           ,UIDСтоимости = @UIDСтоимости
           ,IdСтатусАвто = @IdСтатусАвто
           ,IdТипТоплива = @IdТипТоплива
           ,IdТипПривода = @IdТипПривода 
           ,IdТипРуля = @IdТипРуля
           ,IdТипКПП = @IdТипКПП
           ,UIDИзменяющего = dbo.ШтатПолучитьUIDСотрудника()
           ,ДатаИзменения = dbo.DtТекущаяДатаВремя()
           ,ГодВыпуска = @ГодВыпуска
           ,Пробег = @Пробег
           ,ЦветRGB = @ЦветRGB
           ,VIN = @VIN
           ,ОбъемДвигателя = @ОбъемДвигателя
           ,МощностьДвигателя = @МощностьДвигателя
           ,НомерКузова = @НомерКузова
        WHERE UIDТовара = @UIDТовара
            
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
         
        DELETE ГаражСтоимостьАвто WHERE UIDТовара = @UIDТовара
        DELETE ГаражАвто WHERE UIDТовара = @UIDТовара

        IF (@@ERROR != 0 OR @@TRANCOUNT = 0) 
        BEGIN 
            IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION   
        END
        IF @@TRANCOUNT != 0 BEGIN COMMIT TRANSACTION END   	
    END 

    IF @Function IN (2, 3) BEGIN SELECT @UIDТовара AS id END 
END
GO