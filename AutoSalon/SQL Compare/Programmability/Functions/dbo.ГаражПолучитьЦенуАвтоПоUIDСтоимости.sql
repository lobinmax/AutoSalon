SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE FUNCTION [dbo].[ГаражПолучитьЦенуАвтоПоUIDСтоимости] 
(
    @UIDСтоимости AS UNIQUEIDENTIFIER
)
RETURNS MONEY
AS
BEGIN
    RETURN 
    (
        SELECT гса.Стоимость
        FROM ГаражСтоимостьАвто гса
        WHERE гса.UIDСтоимостиАвто = @UIDСтоимости 
    )
END
GO