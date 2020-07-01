SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[АвтоТипКПП_SIUD]
    @IdТипКПП TINYINT = NULL,
    @Наименование VARCHAR(100) = NULL,
    @НаименованиеСокр VARCHAR(100) = NULL,
    @Function TINYINT = 0
AS 
BEGIN 
    
    -- для формы
    IF @Function = 0 
    BEGIN  
       	SELECT атк.IdТипКПП
              ,атк.Наименование
              ,атк.[Наименование сокр.]     
        FROM АвтоТипКПП атк
        WHERE (@IdТипКПП IS NULL OR атк.IdТипКПП = @IdТипКПП)
        ORDER BY атк.Наименование 
    END
        
    -- select
    IF @Function = 1 
    BEGIN   
       	SELECT атк.IdТипКПП
              ,атк.Наименование
              ,атк.[Наименование сокр.]     
        FROM АвтоТипКПП атк
        WHERE (@IdТипКПП IS NULL OR атк.IdТипКПП = @IdТипКПП)
        ORDER BY атк.Наименование 
    END
        
    -- insert
    IF @Function = 2 
    BEGIN  
        BEGIN TRANSACTION 

        INSERT АвтоТипКПП (Наименование, [Наименование сокр.])
        VALUES (@Наименование, @НаименованиеСокр)

        COMMIT TRANSACTION
    END
        
    -- update
    IF @Function = 3 
    BEGIN  
        BEGIN TRANSACTION 

        UPDATE АвтоТипКПП 
        SET Наименование = @Наименование
           ,[Наименование сокр.] = @НаименованиеСокр
        WHERE IdТипКПП = @IdТипКПП 

        COMMIT TRANSACTION
    END
        
    -- delete
    IF @Function = 4 
    BEGIN  
        BEGIN TRANSACTION 

        DELETE FROM АвтоТипКПП
        WHERE IdТипКПП = @IdТипКПП
        
        COMMIT TRANSACTION
    END	
    
    IF @Function IN (2, 3) BEGIN SELECT SCOPE_IDENTITY() END 

END
GO