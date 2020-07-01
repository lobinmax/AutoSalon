SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ТипыСтатусовЗаказа_SIUD]
    @IdСтатусЗаказа TINYINT = NULL,
    @Наименование VARCHAR(100) = NULL,
    @Function TINYINT = 0
AS 
BEGIN 
    
    -- для формы
    IF @Function = 0 
    BEGIN  
       	SELECT зс.IdСтатусЗаказа, 
               зс.Наименование
        FROM ЗаказыСтатусы зс
        WHERE (@IdСтатусЗаказа IS NULL OR зс.IdСтатусЗаказа = @IdСтатусЗаказа)
        ORDER BY зс.Наименование
    END
        
    -- select
    IF @Function = 1 
    BEGIN   
       	SELECT зс.IdСтатусЗаказа, 
               зс.Наименование
        FROM ЗаказыСтатусы зс
        WHERE (@IdСтатусЗаказа IS NULL OR зс.IdСтатусЗаказа = @IdСтатусЗаказа)
        ORDER BY зс.Наименование
    END
        
    -- insert
    IF @Function = 2 
    BEGIN  
        BEGIN TRANSACTION 

        INSERT ЗаказыСтатусы (Наименование)
        VALUES (@Наименование)

        COMMIT TRANSACTION
    END
        
    -- update
    IF @Function = 3 
    BEGIN  
        BEGIN TRANSACTION 

        UPDATE ЗаказыСтатусы 
        SET Наименование = @Наименование
        WHERE IdСтатусЗаказа = @IdСтатусЗаказа 

        COMMIT TRANSACTION
    END
        
    -- delete
    IF @Function = 4 
    BEGIN  
        BEGIN TRANSACTION 

        DELETE FROM ЗаказыСтатусы
        WHERE IdСтатусЗаказа = @IdСтатусЗаказа
        
        COMMIT TRANSACTION
    END	
    
    IF @Function IN (2, 3) BEGIN SELECT SCOPE_IDENTITY() END 

END
GO