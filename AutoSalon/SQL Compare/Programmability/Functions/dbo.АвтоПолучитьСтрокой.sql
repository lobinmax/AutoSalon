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
            ам.Наименование + ' - ' + аМод.Наименование + ' (' + ап.Наименование + ' - ' + CAST(ап.НачалоПроизводства AS VARCHAR(4)) + ' г.) | ' + га.ГодВыпуска + ' г.в. | VIN: ' + га.VIN
        FROM dbo.ГаражАвто га
        INNER JOIN dbo.АвтоМарки ам
            ON га.UIDМарки = ам.UIDМарки
        INNER JOIN dbo.АвтоМодели аМод
            ON га.UIDМодели = аМод.UIDМодели
        INNER JOIN dbo.АвтоПоколение ап
            ON га.UIDПоколения = ап.UIDПоколения
        INNER JOIN АвтоТипКузова атк
            ON ап.IdТипКузова = атк.IdТипКузова
        WHERE га.UIDТовара = @UIDТовара
    )

    RETURN @АвтоСтрока
END
GO