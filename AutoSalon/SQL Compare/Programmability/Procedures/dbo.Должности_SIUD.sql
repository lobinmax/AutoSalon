SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[Должности_SIUD]
    @IdДолжности INT =  NULL, 
    @Function TINYINT = 0 -- 0 - источник данных формы

AS 
BEGIN
	SET NOCOUNT ON
    SET XACT_ABORT ON

    IF @Function = 0 
    BEGIN
    	SELECT шд.IdДолжности AS Id
              ,шд.Наименование
              ,шд.СервернаяРоль 
        FROM dbo.ШтатДолжности AS шд
        WHERE (@IdДолжности IS NULL OR шд.IdДолжности = @IdДолжности)
    END
END
GO