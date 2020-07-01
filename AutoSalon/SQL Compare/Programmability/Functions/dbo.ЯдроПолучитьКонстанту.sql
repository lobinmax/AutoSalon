SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE FUNCTION [dbo].[ЯдроПолучитьКонстанту]
(
    @ИмяКонстанты VARCHAR(300)
)
RETURNS SQL_VARIANT
AS 
BEGIN
    DECLARE @Value AS SQL_VARIANT

   	SELECT @Value = k.Значение 
    FROM ЯдроКонстанты k 
    WHERE k.Наименование = @ИмяКонстанты
    
    RETURN @Value
END
GO