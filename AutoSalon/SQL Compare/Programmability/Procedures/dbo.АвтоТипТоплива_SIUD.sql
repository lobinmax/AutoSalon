SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[АвтоТипТоплива_SIUD]
    @IdТипТоплива TINYINT = NULL,
    @Наименование VARCHAR(100) = NULL,
    @Function TINYINT = 0
AS 
BEGIN 
    
    -- для формы
    IF @Function = 0 
    BEGIN  
       	SELECT атт.IdТипТоплива, 
               атт.Наименование
        FROM АвтоТипТоплива атт
        WHERE (@IdТипТоплива IS NULL OR атт.IdТипТоплива = @IdТипТоплива)
        ORDER BY атт.Наименование
    END
        
    -- select
    IF @Function = 1 
    BEGIN   
       	SELECT атт.IdТипТоплива, 
               атт.Наименование
        FROM АвтоТипТоплива атт
        WHERE (@IdТипТоплива IS NULL OR атт.IdТипТоплива = @IdТипТоплива)
        ORDER BY атт.Наименование
    END
        
    -- insert
    IF @Function = 2 
    BEGIN  
        BEGIN TRANSACTION 

        INSERT АвтоТипТоплива (Наименование)
        VALUES (@Наименование)

        COMMIT TRANSACTION
    END
        
    -- update
    IF @Function = 3 
    BEGIN  
        BEGIN TRANSACTION 

        UPDATE АвтоТипТоплива 
        SET Наименование = @Наименование
        WHERE IdТипТоплива = @IdТипТоплива 

        COMMIT TRANSACTION
    END
        
    -- delete
    IF @Function = 4 
    BEGIN  
        BEGIN TRANSACTION 

        DELETE FROM АвтоТипТоплива
        WHERE IdТипТоплива = @IdТипТоплива
        
        COMMIT TRANSACTION
    END	
    
    IF @Function IN (2, 3) BEGIN SELECT SCOPE_IDENTITY() END 

END
GO