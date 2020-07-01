SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ТипыСтатусовТовара_SIUD]
    @IdСтатусТовара TINYINT = NULL,
    @Наименование VARCHAR(100) = NULL,
    @Function TINYINT = 0
AS 
BEGIN 
    
    -- для формы
    IF @Function = 0 
    BEGIN  
       	SELECT гса.IdСтатусАвто, 
               гса.Наименование
        FROM ГаражСтатусАвто гса
        WHERE (@IdСтатусТовара IS NULL OR гса.IdСтатусАвто = @IdСтатусТовара)
        ORDER BY гса.Наименование
    END
        
    -- select
    IF @Function = 1 
    BEGIN   
       	SELECT гса.IdСтатусАвто, 
               гса.Наименование
        FROM ГаражСтатусАвто гса
        WHERE (@IdСтатусТовара IS NULL OR гса.IdСтатусАвто = @IdСтатусТовара)
        ORDER BY гса.Наименование
    END
        
    -- insert
    IF @Function = 2 
    BEGIN  
        BEGIN TRANSACTION 

        INSERT ГаражСтатусАвто (Наименование)
        VALUES (@Наименование)

        COMMIT TRANSACTION
    END
        
    -- update
    IF @Function = 3 
    BEGIN  
        BEGIN TRANSACTION 

        UPDATE ГаражСтатусАвто 
        SET Наименование = @Наименование
        WHERE IdСтатусАвто = @IdСтатусТовара 

        COMMIT TRANSACTION
    END
        
    -- delete
    IF @Function = 4 
    BEGIN  
        BEGIN TRANSACTION 

        DELETE FROM ГаражСтатусАвто
        WHERE IdСтатусАвто = @IdСтатусТовара
        
        COMMIT TRANSACTION
    END	
    
    IF @Function IN (2, 3) BEGIN SELECT SCOPE_IDENTITY() END 

END
GO