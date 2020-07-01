SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE FUNCTION [dbo].[ГаражПолучитьЦенуАвто] 
(
    @UIDТовара AS UNIQUEIDENTIFIER
)
RETURNS MONEY
AS BEGIN
    RETURN 
    (
        SELECT TOP (1) гса.Стоимость 
        FROM ГаражСтоимостьАвто гса
        WHERE гса.UIDТовара = @UIDТовара
        ORDER BY гса.ДатаСтоимости DESC
    )
END
GO