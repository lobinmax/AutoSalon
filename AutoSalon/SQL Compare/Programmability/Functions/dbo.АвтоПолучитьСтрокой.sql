SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE FUNCTION [dbo].[АвтоПолучитьСтрокой] 
(
    @UIDТовара UNIQUEIDENTIFIER
)
RETURNS VARCHAR(MAX)
AS
BEGIN
	DECLARE @АвтоСтрока VARCHAR(MAX) = 
    (
        SELECT
            ам.Наименование + ' - ' + аМод.Наименование + ' (' + ап.Наименование + ') | ' + га.ГодВыпуска + ' г.в. | VIN: ' + га.VIN
        FROM dbo.ГаражАвто га
        INNER JOIN dbo.АвтоМарки ам
            ON га.UIDМарки = ам.UIDМарки
        INNER JOIN dbo.АвтоМодели аМод
            ON га.UIDМодели = аМод.UIDМодели
        INNER JOIN dbo.АвтоПоколение ап
            ON га.UIDПоколения = ап.UIDПоколения
        WHERE га.UIDТовара = @UIDТовара
    )

    RETURN @АвтоСтрока
END
GO