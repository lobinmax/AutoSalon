SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE FUNCTION [dbo].[ЗаказыГенераторНомера]()

RETURNS VARCHAR(20)
AS
BEGIN
	DECLARE @Номер VARCHAR(20) = 
    (
        SELECT CAST(COUNT(з.UIDЗаказа) + 1 AS VARCHAR(20)) + '-' + CAST(YEAR(dbo.DtТекущаяДата()) AS VARCHAR) 
        FROM Заказы з
    )

    RETURN @Номер
END
GO