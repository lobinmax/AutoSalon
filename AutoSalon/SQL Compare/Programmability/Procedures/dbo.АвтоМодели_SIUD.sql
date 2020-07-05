SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[АвтоМодели_SIUD]
    @UIDМодели UNIQUEIDENTIFIER = NULL,
    @UIDМарки UNIQUEIDENTIFIER = NULL,
    @Модель VARCHAR(300) = NULL,
    @НачалоПроизводства VARCHAR(10) = NULL,
    @ОкончаниеПроизводства VARCHAR(10) = NULL,
    @Function INT = 0
    
AS 
BEGIN
	
    -- для формы
    IF @Function = 0 
    BEGIN  
       	SELECT ам.UIDМарки, 
               ам.UIDМодели, 
               ам.Марка AS [Марка автомобиля], 
               ам.Модель AS [Модель автомобиля], 
               ам.[Начало производства], 
               ам.[Окончание производства] 
        FROM vАвтоМодели ам
        WHERE (@UIDМарки IS NULL OR ам.UIDМарки = @UIDМарки)
        ORDER BY ам.Модель
    END
        
    -- select
    IF @Function = 1 
    BEGIN  
        SELECT ам.UIDМарки, 
               ам1.UIDМодели, 
               ам.Наименование AS Марка, 
               ам1.Наименование AS Модель , 
               ам1.НачалоПроизводства AS [Начало производства], 
               ам1.ОкончаниеПроизводства AS [Окончание производства]
        FROM АвтоМарки ам
        LEFT JOIN АвтоМодели ам1
            ON ам.UIDМарки = ам1.UIDМарки
        WHERE (@UIDМодели IS NULL OR ам1.UIDМодели = @UIDМодели)
            AND (@UIDМарки IS NULL OR ам.UIDМарки = @UIDМарки)
    END       
          
    -- insert
    IF @Function = 2 
    BEGIN
          
        BEGIN TRANSACTION 
    
        SET @UIDМодели = NEWID()
        INSERT АвтоМодели ( UIDМодели, UIDМарки, Наименование, НачалоПроизводства, ОкончаниеПроизводства)
        VALUES ( @UIDМодели, @UIDМарки, @Модель, @НачалоПроизводства, @ОкончаниеПроизводства) 

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
        
        UPDATE АвтоМодели 
        SET UIDМарки = @UIDМарки
           ,Наименование = @Модель
           ,НачалоПроизводства = @НачалоПроизводства
           ,ОкончаниеПроизводства = @ОкончаниеПроизводства
        WHERE UIDМодели = @UIDМодели
            
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
        
        DELETE АвтоПоколение WHERE UIDМодели = @UIDМодели
        DELETE АвтоМодели WHERE UIDМодели = @UIDМодели

        IF (@@ERROR != 0 OR @@TRANCOUNT = 0) 
        BEGIN 
            IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION   
        END
        IF @@TRANCOUNT != 0 BEGIN COMMIT TRANSACTION END   	
    END	

    IF @Function IN (2, 3) BEGIN SELECT @UIDМодели END 
END
GO