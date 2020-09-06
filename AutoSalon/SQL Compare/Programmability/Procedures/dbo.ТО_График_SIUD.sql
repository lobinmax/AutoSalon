SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ТО_График_SIUD]
    @IdТО TINYINT = NULL,
    @Наименование VARCHAR(150) = NULL,
    @СрокГод INT = NULL,
    @СрокМесяц INT = NULL,
    @Function TINYINT = 0
AS 
BEGIN 

    -- для формы
    IF @Function = 0 
    BEGIN  
       	SELECT тг.IdТО, 
               тг.Наименование, 
               тг.СрокГод, 
               тг.СрокМесяц
        FROM ТО_График тг
        WHERE (@IdТО IS NULL OR тг.IdТО = @IdТО)
        ORDER BY тг.Наименование 
    END
        
    -- select
    IF @Function = 1 
    BEGIN   
       	SELECT тг.IdТО, 
               тг.Наименование, 
               тг.СрокГод, 
               тг.СрокМесяц
        FROM ТО_График тг
        WHERE (@IdТО IS NULL OR тг.IdТО = @IdТО)
        ORDER BY тг.Наименование 
    END
        
    -- insert
    IF @Function = 2 
    BEGIN  
        BEGIN TRANSACTION 

        INSERT ТО_График (Наименование, СрокГод, СрокМесяц)
        VALUES (@Наименование, @СрокГод, @СрокМесяц);

        COMMIT TRANSACTION
    END
        
    -- update
    IF @Function = 3 
    BEGIN  
        BEGIN TRANSACTION 

        UPDATE ТО_График 
        SET Наименование = @Наименование,
            СрокГод = @СрокГод,
            СрокМесяц = @СрокМесяц
        WHERE IdТО = @IdТО

        COMMIT TRANSACTION
    END
        
    -- delete
    IF @Function = 4 
    BEGIN  
        BEGIN TRANSACTION 

        DELETE FROM ТО_График
        WHERE IdТО = @IdТО
        
        COMMIT TRANSACTION
    END	
    
    IF @Function IN (2, 3) BEGIN SELECT @IdТО END 

END 
GO