SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE FUNCTION [dbo].[ШтатПолучитьUIDСотрудника] ()
RETURNS UNIQUEIDENTIFIER
AS
BEGIN
    DECLARE @IUDСотрудника AS UNIQUEIDENTIFIER
    DECLARE @Login AS VARCHAR(150) = SYSTEM_USER

    SELECT
        @IUDСотрудника = CASE WHEN @Login = 'sa' THEN 
                            '4EF62F54-D8B0-4911-A3C3-C3D640B4BDA9' 
                         ELSE 
                            шс.UIDСотрудника 
                         END 
    FROM ШтатСотрудники шс
    WHERE шс.Логин = SYSTEM_USER

    RETURN @IUDСотрудника
END
GO