SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ГаражСтоимостьАвтоИстория]
    @UIDТовара AS UNIQUEIDENTIFIER = NULL 

AS
BEGIN
    SELECT гса.UIDСтоимостиАвто
          ,гса.UIDТовара
          ,гса.ДатаСтоимости
          ,гса.Стоимость AS [Цена]
          ,гса.ДатаСоздания AS [Дата создания]
          ,гса.ДатаИзменения AS [Дата изменения]
          ,dbo.ШтатПолучитьФИОкратко(гса.UIDАвтора) AS [Автор создания]
          ,dbo.ШтатПолучитьФИОкратко(гса.UIDИзменяющего) AS [Автор изменения]
    FROM ГаражСтоимостьАвто гса
    WHERE гса.UIDТовара = @UIDТовара
    ORDER BY гса.ДатаСтоимости DESC

END 
GO