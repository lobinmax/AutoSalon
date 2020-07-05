SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[КлиентаПоискПоФИО]
    @ФИОПоиска AS VARCHAR(MAX) = NULL 
AS 
BEGIN
	SELECT кд.UIDКлиента,
           dbo.КлиентПолучитьФИО(кд.UIDКлиента) AS [ФИО клиента], 
           кд.[Номер телефона]
    FROM КлиентыДанные кд
    WHERE @ФИОПоиска IS NULL OR dbo.КлиентПолучитьФИО(кд.UIDКлиента) LIKE '%' + @ФИОПоиска + '%'
    ORDER BY [ФИО клиента]

END
GO