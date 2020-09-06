SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ТО_Запчасти_SIUD]
    @IdЗапчасти INT = NULL,
    @Наименование VARCHAR(200) = NULL,
    @Стоимость MONEY = NULL, 
    @Function TINYINT = 0
AS 
BEGIN 
    -- для формы
    IF @Function = 0 
    BEGIN  
       	SELECT тз.IdЗапчасти, 
               тз.Наименование, 
               тз.Стоимость
        FROM ТО_Запчасти тз
        WHERE (@IdЗапчасти IS NULL OR тз.IdЗапчасти = @IdЗапчасти)
        ORDER BY тз.Наименование 
    END
        
    -- select
    IF @Function = 1 
    BEGIN   
       	SELECT тз.IdЗапчасти, 
               тз.Наименование, 
               тз.Стоимость
        FROM ТО_Запчасти тз
        WHERE (@IdЗапчасти IS NULL OR тз.IdЗапчасти = @IdЗапчасти)
        ORDER BY тз.Наименование 
    END
        
    -- insert
    IF @Function = 2 
    BEGIN  
        BEGIN TRANSACTION 

        INSERT ТО_Запчасти (Наименование, Стоимость)
        VALUES (@Наименование, @Стоимость);

        COMMIT TRANSACTION
    END
        
    -- update
    IF @Function = 3 
    BEGIN  
        BEGIN TRANSACTION 

        UPDATE ТО_Запчасти 
        SET Наименование = @Наименование,
            Стоимость = @Стоимость
        WHERE IdЗапчасти = @IdЗапчасти

        COMMIT TRANSACTION
    END
        
    -- delete
    IF @Function = 4 
    BEGIN  
        BEGIN TRANSACTION 

        DELETE FROM ТО_Запчасти
        WHERE IdЗапчасти = @IdЗапчасти
        
        COMMIT TRANSACTION
    END	
    
    IF @Function IN (2, 3) BEGIN SELECT @IdЗапчасти END 

END 
GO