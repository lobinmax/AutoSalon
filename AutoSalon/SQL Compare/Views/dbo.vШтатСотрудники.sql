﻿SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO

CREATE VIEW [dbo].[vШтатСотрудники]
AS
SELECT
    шс.UIDСотрудника
   ,CASE
        WHEN шс.Домен != '' THEN шс.Домен + '\'
        ELSE ''
    END + шс.Логин AS [Логин]
   ,dbo.ШтатПолучитьФИО(шс.UIDСотрудника) AS [ФИО]
   ,dbo.ШтатПолучитьФИОкратко(шс.UIDСотрудника) AS [ФИО кратко]
   ,шс.Фамилия
   ,шс.Имя
   ,шс.Отчество
   ,шс.[Дата рождения]
   ,шс.IdДолжности
   ,шд.Наименование AS [Должность]
   ,шд.СервернаяРоль
   ,шс.ДатаСоздания
   ,шс.ДатаИзменения
   ,шс.UIDАвтора
   ,dbo.ШтатПолучитьФИО(шс.UIDАвтора) AS [ФИО Автор]
   ,dbo.ШтатПолучитьФИОкратко(шс.UIDАвтора) AS [ФИО Автор кратко]
   ,шс.UIDИзменяющего
   ,dbo.ШтатПолучитьФИО(шс.UIDИзменяющего) AS [ФИО Изменившего]
   ,dbo.ШтатПолучитьФИОкратко(шс.UIDИзменяющего) AS [ФИО Изменившего кратко]
   ,шс.Телефон
   ,шс.Email
   ,шс.IdПола
   ,кп.Наименование AS [Пол сотрудника]
FROM dbo.ШтатСотрудники AS шс
INNER JOIN dbo.КлиентыПол AS кп
    ON шс.IdПола = кп.IdПола
INNER JOIN dbo.ШтатДолжности AS шд
    ON шс.IdДолжности = шд.IdДолжности
GO