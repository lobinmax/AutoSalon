SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE FUNCTION [dbo].[ШтатПолучитьФИОкратко] 
(
    @UIDСотрудника UNIQUEIDENTIFIER
)
RETURNS VARCHAR(200)
AS
BEGIN
    DECLARE @ФИО VARCHAR(200)
	SELECT @ФИО = CASE WHEN шс.Фамилия IS NOT NULL AND шс.Фамилия != '' THEN шс.Фамилия ELSE '' END + 
                  CASE WHEN шс.Имя IS NOT NULL AND шс.Имя != '' THEN ' ' + LEFT(шс.Имя, 1) + '.' ELSE '' END + 
                  CASE WHEN шс.Отчество IS NOT NULL AND шс.Отчество != '' THEN ' ' + LEFT(шс.Отчество, 1) + '.' ELSE '' END
    FROM dbo.ШтатСотрудники AS шс 
    WHERE шс.UIDСотрудника = @UIDСотрудника
    
    RETURN @ФИО
END
GO