SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE VIEW [dbo].[vАвтоМарки] 
AS SELECT ам.UIDМарки, 
       ам.Наименование AS Марка, 
       с.UIDСтраны, 
       с.Наименование AS Страна, 
       с.[Наименование сокр.] AS [Код страны]
FROM АвтоМарки ам
INNER JOIN Страны с
    ON ам.UIDСтранаПроизводитель = с.UIDСтраны
GO