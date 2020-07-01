SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE FUNCTION [dbo].[ГаражПолучитьЦенуАвтоUID] 
(
    @UIDТовара AS UNIQUEIDENTIFIER
)
RETURNS UNIQUEIDENTIFIER
AS BEGIN
    RETURN 
    (
        SELECT TOP (1) гса.UIDСтоимостиАвто 
        FROM ГаражСтоимостьАвто гса
        WHERE гса.UIDТовара = @UIDТовара
        ORDER BY гса.ДатаСтоимости DESC
    )
END
GO