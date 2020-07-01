SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[АвтоТипПривода_SIUD]
    @IdТипПривода TINYINT = NULL,
    @Наименование VARCHAR(100) = NULL,
    @Function TINYINT = 0
AS 
BEGIN 
    
    -- для формы
    IF @Function = 0 
    BEGIN  
       	SELECT атп.IdТипПривода, 
               атп.Наименование
        FROM АвтоТипПривода атп
        WHERE (@IdТипПривода IS NULL OR атп.IdТипПривода = @IdТипПривода)
        ORDER BY атп.Наименование
    END
        
    -- select
    IF @Function = 1 
    BEGIN   
       	SELECT атп.IdТипПривода, 
               атп.Наименование
        FROM АвтоТипПривода атп
        WHERE (@IdТипПривода IS NULL OR атп.IdТипПривода = @IdТипПривода)
        ORDER BY атп.Наименование
    END
        
    -- insert
    IF @Function = 2 
    BEGIN  
        BEGIN TRANSACTION 

        INSERT АвтоТипПривода (Наименование)
        VALUES (@Наименование)

        COMMIT TRANSACTION
    END
        
    -- update
    IF @Function = 3 
    BEGIN  
        BEGIN TRANSACTION 

        UPDATE АвтоТипПривода 
        SET Наименование = @Наименование
        WHERE IdТипПривода = @IdТипПривода 

        COMMIT TRANSACTION
    END
        
    -- delete
    IF @Function = 4 
    BEGIN  
        BEGIN TRANSACTION 

        DELETE FROM АвтоТипПривода
        WHERE IdТипПривода = @IdТипПривода
        
        COMMIT TRANSACTION
    END	
    
    IF @Function IN (2, 3) BEGIN SELECT SCOPE_IDENTITY() END 

END
GO