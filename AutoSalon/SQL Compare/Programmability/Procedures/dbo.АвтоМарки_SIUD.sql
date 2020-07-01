SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[АвтоМарки_SIUD]
    @UIDМарки UNIQUEIDENTIFIER = NULL,
    @Марка VARCHAR(300) = NULL,
    @UIDСтраны UNIQUEIDENTIFIER = NULL,
    @Function INT = 0
    
AS 
BEGIN
	
    -- для формы
    IF @Function = 0 
    BEGIN  
       	SELECT ам.UIDМарки AS [UIDМарки], 
               ам.Марка,
               ам.UIDСтраны AS [UIDСтраны], 
               ам.Страна, 
               ам.[Код страны] 
        FROM vАвтоМарки ам
        WHERE (@UIDМарки IS NULL OR ам.UIDМарки = @UIDМарки)
        ORDER BY ам.Марка, ам.Страна
    END
        
    -- select
    IF @Function = 1 
    BEGIN  
        SELECT ам.UIDМарки, 
               ам.Наименование, 
               ам.UIDСтранаПроизводитель 
        FROM АвтоМарки ам
        WHERE (@UIDМарки IS NULL OR ам.UIDМарки = @UIDМарки)
    END       
          
    -- insert
    IF @Function = 2 
    BEGIN
          
        BEGIN TRANSACTION 
        
        SET @UIDМарки = NEWID()
        INSERT АвтоМарки (UIDМарки, Наименование, UIDСтранаПроизводитель)
        VALUES (@UIDМарки, @Марка, @UIDСтраны);

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
        
        UPDATE АвтоМарки 
        SET Наименование = @Марка
           ,UIDСтранаПроизводитель = @UIDСтраны
        WHERE UIDМарки = @UIDМарки
            
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
         
        DELETE АвтоПоколение WHERE UIDМарки = @UIDМарки
        DELETE АвтоМодели WHERE UIDМарки = @UIDМарки
        DELETE АвтоМарки WHERE UIDМарки = @UIDМарки

        IF (@@ERROR != 0 OR @@TRANCOUNT = 0) 
        BEGIN 
            IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION   
        END
        IF @@TRANCOUNT != 0 BEGIN COMMIT TRANSACTION END   	
    END	

    IF @Function IN (2, 3) BEGIN SELECT @UIDМарки AS id END 
END
GO