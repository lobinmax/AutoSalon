SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE FUNCTION [dbo].[ШтатПолучитьUIDСотрудника] ()
RETURNS UNIQUEIDENTIFIER
AS
BEGIN
    DECLARE @IUDСотрудника AS UNIQUEIDENTIFIER
    DECLARE @Login AS VARCHAR(150) = SYSTEM_USER
    
    IF @Login = 'sa'
    BEGIN
        SET @IUDСотрудника = '4EF62F54-D8B0-4911-A3C3-C3D640B4BDA9' 
    END 
    ELSE 
    BEGIN
        SELECT @IUDСотрудника = шс.UIDСотрудника
        FROM ШтатСотрудники шс
        WHERE шс.Домен + '\' + шс.Логин = SYSTEM_USER
    END 

    RETURN @IUDСотрудника
END
GO