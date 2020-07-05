SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[АвтоПоколения_SIUD]
    @UIDПоколения UNIQUEIDENTIFIER = NULL,
    @UIDМодели UNIQUEIDENTIFIER = NULL,
    @UIDМарки UNIQUEIDENTIFIER = NULL,
    @Поколение VARCHAR(300) = NULL,
    @НачалоПроизводства VARCHAR(10) = NULL,
    @ОкончаниеПроизводства VARCHAR(10) = NULL,
    @IdТипКузова AS TINYINT = NULL,
    @Function INT = 0
    
AS 
BEGIN
	
    -- для формы
    IF @Function = 0 
    BEGIN
        SELECT ma.UIDМарки,
               mo.UIDМодели,
               po.UIDПоколения,
               ma.Наименование AS Марка,
               mo.Наименование AS Модель,
               po.Наименование AS Поколение,
               атк.Наименование AS [Тип кузова],
               po.НачалоПроизводства AS [Начало производства],
               po.ОкончаниеПроизводства AS [Окончание производства]
        FROM dbo.АвтоМарки ma
        INNER JOIN dbo.АвтоМодели mo
            ON ma.UIDМарки = mo.UIDМарки
        INNER JOIN dbo.АвтоПоколение po
            ON ma.UIDМарки = po.UIDМарки
                AND mo.UIDМодели = po.UIDМодели
        INNER JOIN АвтоТипКузова атк
            ON po.IdТипКузова = атк.IdТипКузова
        WHERE (@UIDМодели IS NULL OR mo.UIDМодели = @UIDМодели)
            ORDER BY [Начало производства]
    END
        
    -- select
    IF @Function = 1 
    BEGIN
        SELECT ап.UIDМарки, 
               ап.UIDМодели, 
               ап.UIDПоколения, 
               ап.Марка, 
               ап.Модель, 
               ап.Поколение, 
               ап.IdТипКузова,
               ап.[Начало производства], 
               ап.[Окончание производства]
        FROM vАвтоПоколения ап
        WHERE (@UIDПоколения IS NULL OR ап.UIDПоколения = @UIDПоколения)
            AND (@UIDМодели IS NULL OR ап.UIDМодели = @UIDМодели)
        ORDER BY ап.Марка, ап.Модель, ап.Поколение
    END       
          
    -- insert
    IF @Function = 2 
    BEGIN
          
        BEGIN TRANSACTION 
    
        SET @UIDПоколения = NEWID()
        INSERT АвтоПоколение (UIDПоколения, UIDМодели, UIDМарки, Наименование, IdТипКузова, НачалоПроизводства, ОкончаниеПроизводства)
        VALUES (@UIDПоколения, @UIDМодели, @UIDМарки, @Поколение, @IdТипКузова, @НачалоПроизводства, @ОкончаниеПроизводства) 

        IF (@@ERROR != 0 OR @@TRANCOUNT = 0) 
        BEGIN 
            IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION   
        END
        IF @@TRANCOUNT != 0 BEGIN COMMIT TRANSACTION END   	
    END
       
    -- update
    IF @Function = 3 
    BEGIN
          
        BEGIN TRANSACTION 
        
        UPDATE АвтоПоколение 
        SET UIDМодели = @UIDМодели
           ,UIDМарки = @UIDМарки
           ,Наименование = @Поколение
           ,IdТипКузова = @IdТипКузова
           ,НачалоПроизводства = @НачалоПроизводства
           ,ОкончаниеПроизводства = @ОкончаниеПроизводства
        WHERE UIDПоколения = @UIDПоколения
            
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
        
        DELETE АвтоПоколение WHERE UIDПоколения = @UIDПоколения

        IF (@@ERROR != 0 OR @@TRANCOUNT = 0) 
        BEGIN 
            IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION   
        END
        IF @@TRANCOUNT != 0 BEGIN COMMIT TRANSACTION END   	
    END	

    IF @Function IN (2, 3) BEGIN SELECT @UIDПоколения END 
END
GO