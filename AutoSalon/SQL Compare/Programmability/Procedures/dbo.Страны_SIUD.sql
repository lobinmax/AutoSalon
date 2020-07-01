SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[Страны_SIUD]
    @UIDСтраны UNIQUEIDENTIFIER = NULL,
    @Наименование VARCHAR(100) = NULL,
    @НаименованиеСокр VARCHAR(100) = NULL,
    @Function TINYINT = 0
AS 
BEGIN 
    
    -- для формы
    IF @Function = 0 
    BEGIN  
       	SELECT с.UIDСтраны, 
               с.Наименование, 
               с.[Наименование сокр.]     
        FROM Страны с
        WHERE (@UIDСтраны IS NULL OR с.UIDСтраны = @UIDСтраны)
        ORDER BY с.Наименование
    END
        
    -- select
    IF @Function = 1 
    BEGIN   
       	SELECT с.UIDСтраны, 
               с.Наименование, 
               с.[Наименование сокр.]     
        FROM Страны с
        WHERE (@UIDСтраны IS NULL OR с.UIDСтраны = @UIDСтраны)
        ORDER BY с.Наименование 
    END
        
    -- insert
    IF @Function = 2 
    BEGIN  
        BEGIN TRANSACTION 
        
        SET @UIDСтраны = NEWID()
        INSERT Страны (UIDСтраны, Наименование, [Наименование сокр.])
        VALUES (@UIDСтраны, @Наименование, @НаименованиеСокр)

        COMMIT TRANSACTION
    END
        
    -- update
    IF @Function = 3 
    BEGIN  
        BEGIN TRANSACTION 

        UPDATE Страны
        SET Наименование = @Наименование
           ,[Наименование сокр.] = @НаименованиеСокр
        WHERE UIDСтраны = @UIDСтраны 

        COMMIT TRANSACTION
    END
        
    -- delete
    IF @Function = 4 
    BEGIN  
        BEGIN TRANSACTION 

        DELETE FROM Страны
        WHERE UIDСтраны = @UIDСтраны
        
        COMMIT TRANSACTION
    END	
    
    IF @Function IN (2, 3) BEGIN SELECT @UIDСтраны END 

END
GO