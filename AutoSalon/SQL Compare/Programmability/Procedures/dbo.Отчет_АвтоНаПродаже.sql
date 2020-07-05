﻿SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[Отчет_АвтоНаПродаже]
AS 
BEGIN
	
    SELECT
       ам.Наименование AS Марка
       ,ам1.Наименование AS Модель
       ,ап.Наименование AS Поколение
       ,га.ГодВыпуска AS Год
       ,га.Пробег
       ,dbo.ГаражПолучитьЦенуАвто(га.UIDТовара) AS Цена
       ,га.ЦветRGB AS [Цвет авто]
       ,га.ОбъемДвигателя AS ОбъемДвигателя
       ,га.МощностьДвигателя AS Мощность
       ,атк.Наименование AS [Тип кузова]
       ,атк1.[Наименование сокр.] AS КПП
    FROM dbo.ГаражАвто га
    INNER JOIN dbo.АвтоМарки ам
        ON га.UIDМарки = ам.UIDМарки
    INNER JOIN dbo.АвтоМодели ам1
        ON га.UIDМодели = ам1.UIDМодели
    INNER JOIN dbo.АвтоПоколение ап
        ON га.UIDПоколения = ап.UIDПоколения
    INNER JOIN dbo.ГаражСтатусАвто гса
        ON га.IdСтатусАвто = гса.IdСтатусАвто
    INNER JOIN dbo.АвтоТипКузова атк
        ON ап.IdТипКузова = атк.IdТипКузова
    INNER JOIN dbo.АвтоТипКПП атк1
        ON га.IdТипКПП = атк1.IdТипКПП
    WHERE гса.Наименование = 'В продаже'
    ORDER BY ам.Наименование, ам1.Наименование, ап.Наименование
END
GO