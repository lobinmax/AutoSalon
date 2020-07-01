SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[АвтоТипКузова_SIUD]
    @IdТипКузова TINYINT = NULL,
    @Наименование VARCHAR(100) = NULL,
    @Function TINYINT = 0
AS 
BEGIN 
    
    -- для формы
    IF @Function = 0 
    BEGIN  
       	SELECT атк.IdТипКузова
              ,атк.Наименование
        FROM АвтоТипКузова атк
        WHERE (@IdТипКузова IS NULL OR атк.IdТипКузова = @IdТипКузова)
        ORDER BY атк.Наименование 
    END
        
    -- select
    IF @Function = 1 
    BEGIN   
       	SELECT атк.IdТипКузова
              ,атк.Наименование
        FROM АвтоТипКузова атк
        WHERE (@IdТипКузова IS NULL OR атк.IdТипКузова = @IdТипКузова)
        ORDER BY атк.Наименование
    END
        
    -- insert
    IF @Function = 2 
    BEGIN  
        BEGIN TRANSACTION 

        INSERT АвтоТипКузова (Наименование)
        VALUES (@Наименование)

        COMMIT TRANSACTION
    END
        
    -- update
    IF @Function = 3 
    BEGIN  
        BEGIN TRANSACTION 

        UPDATE АвтоТипКузова 
        SET Наименование = @Наименование 
        WHERE IdТипКузова = @IdТипКузова 

        COMMIT TRANSACTION
    END
        
    -- delete
    IF @Function = 4 
    BEGIN  
        BEGIN TRANSACTION 

        DELETE FROM АвтоТипКузова
        WHERE IdТипКузова = @IdТипКузова
        
        COMMIT TRANSACTION
    END	
    
    IF @Function IN (2, 3) BEGIN SELECT SCOPE_IDENTITY() END 

END
GO