SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ТО_ВидыРемонта_SIUD]
    @IdВидаРемонта TINYINT = NULL,
    @Наименование VARCHAR(200) = NULL,
    @Стоимость MONEY = NULL, 
    @Function TINYINT = 0
AS 
BEGIN
    -- для формы
    IF @Function = 0 
    BEGIN  
       	SELECT твр.IdВидаРемонта, 
               твр.Наименование, 
               твр.Стоимость
        FROM ТО_ВидыРемонта твр
        WHERE (@IdВидаРемонта IS NULL OR твр.IdВидаРемонта = @IdВидаРемонта)
        ORDER BY твр.Наименование 
    END
        
    -- select
    IF @Function = 1 
    BEGIN   
       	SELECT твр.IdВидаРемонта, 
               твр.Наименование, 
               твр.Стоимость
        FROM ТО_ВидыРемонта твр
        WHERE (@IdВидаРемонта IS NULL OR твр.IdВидаРемонта = @IdВидаРемонта)
        ORDER BY твр.Наименование 
    END
        
    -- insert
    IF @Function = 2 
    BEGIN  
        BEGIN TRANSACTION 

        INSERT ТО_ВидыРемонта (Наименование, Стоимость)
        VALUES (@Наименование, @Стоимость)

        COMMIT TRANSACTION
    END
        
    -- update
    IF @Function = 3 
    BEGIN  
        BEGIN TRANSACTION 

        UPDATE ТО_ВидыРемонта 
        SET Наименование = @Наименование,
            Стоимость = @Стоимость
        WHERE IdВидаРемонта = @IdВидаРемонта 

        COMMIT TRANSACTION
    END
        
    -- delete
    IF @Function = 4 
    BEGIN  
        BEGIN TRANSACTION 

        DELETE FROM ТО_ВидыРемонта
        WHERE IdВидаРемонта = @IdВидаРемонта
        
        COMMIT TRANSACTION
    END	
    
    IF @Function IN (2, 3) BEGIN SELECT @IdВидаРемонта END 

END 
GO