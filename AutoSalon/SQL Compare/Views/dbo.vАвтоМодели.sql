SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE VIEW [dbo].[vАвтоМодели] 
AS SELECT
    ам.UIDМарки
   ,ам.UIDМодели
   ,ам1.Наименование AS Марка
   ,ам.Наименование AS Модель
   ,ам.НачалоПроизводства AS [Начало производства]
   ,ам.ОкончаниеПроизводства AS [Окончание производства]
FROM dbo.АвтоМодели ам
RIGHT OUTER JOIN dbo.АвтоМарки ам1
    ON ам.UIDМарки = ам1.UIDМарки
GO