SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE FUNCTION [dbo].[ТО_ОпределитьСтоимостьРаботы]
(
    @IdВидаРемонта INT 
)
RETURNS MONEY
AS BEGIN
    RETURN 
    (
        SELECT ISNULL(твр.Стоимость, CAST(0.00 AS MONEY)) 
        FROM ТО_ВидыРемонта твр 
        WHERE твр.IdВидаРемонта = @IdВидаРемонта
    )    
END 
GO