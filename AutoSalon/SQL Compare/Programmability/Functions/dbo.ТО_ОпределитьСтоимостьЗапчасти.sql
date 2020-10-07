SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE FUNCTION [dbo].[ТО_ОпределитьСтоимостьЗапчасти]
(
    @IdЗапчасти INT 
)
RETURNS MONEY
AS BEGIN
    RETURN 
    (
        SELECT ISNULL(тз.Стоимость, CAST(0.00 AS MONEY)) 
        FROM ТО_Запчасти тз 
        WHERE тз.IdЗапчасти = @IdЗапчасти
    )    
END 
GO