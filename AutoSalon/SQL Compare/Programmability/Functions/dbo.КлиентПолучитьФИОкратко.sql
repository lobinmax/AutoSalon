SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE FUNCTION [dbo].[КлиентПолучитьФИОкратко] 
(
    @UIDКлиента UNIQUEIDENTIFIER
)
RETURNS VARCHAR(200)
AS
BEGIN
    DECLARE @ФИО VARCHAR(200)
	SELECT @ФИО = CASE WHEN кд.Фамилия IS NOT NULL AND кд.Фамилия != '' THEN кд.Фамилия ELSE '' END + 
                  CASE WHEN кд.Имя IS NOT NULL AND кд.Имя != '' THEN ' ' + LEFT(кд.Имя, 1) + '.' ELSE '' END + 
                  CASE WHEN кд.Отчество IS NOT NULL AND кд.Отчество != '' THEN ' ' + LEFT(кд.Отчество, 1) + '.' ELSE '' END
    FROM КлиентыДанные кд 
    WHERE кд.UIDКлиента = @UIDКлиента
    
    RETURN @ФИО
END
GO