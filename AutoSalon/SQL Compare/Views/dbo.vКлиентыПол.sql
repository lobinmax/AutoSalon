SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE VIEW [dbo].[vКлиентыПол]
AS
SELECT
    кп.IdПола AS Id
   ,кп.Наименование AS [Наименование]
FROM КлиентыПол кп
GO