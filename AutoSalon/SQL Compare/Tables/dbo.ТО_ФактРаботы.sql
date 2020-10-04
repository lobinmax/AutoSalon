CREATE TABLE [dbo].[ТО_ФактРаботы] (
  [UIDРаботы] [uniqueidentifier] NOT NULL DEFAULT (newid()),
  [UIDТО] [uniqueidentifier] NOT NULL,
  [IdВидаРемонта] [int] NOT NULL,
  [Стоимость] [money] NOT NULL,
  [ДатаСоздания] [datetime] NOT NULL DEFAULT ([dbo].[DtТекущаяДатаВремя]()),
  [UIDАвтора] [uniqueidentifier] NOT NULL DEFAULT ([dbo].[ШтатПолучитьUIDСотрудника]()),
  CONSTRAINT [PK_ТО_ФактРаботы_UIDРаботы] PRIMARY KEY CLUSTERED ([UIDРаботы])
)
ON [PRIMARY]
GO

ALTER TABLE [dbo].[ТО_ФактРаботы]
  ADD CONSTRAINT [FK_ТО_ФактРаботы_IdВидаРемонта] FOREIGN KEY ([IdВидаРемонта]) REFERENCES [dbo].[ТО_ВидыРемонта] ([IdВидаРемонта])
GO

ALTER TABLE [dbo].[ТО_ФактРаботы]
  ADD CONSTRAINT [FK_ТО_ФактРаботы_UIDАвтора] FOREIGN KEY ([UIDАвтора]) REFERENCES [dbo].[ШтатСотрудники] ([UIDСотрудника])
GO

ALTER TABLE [dbo].[ТО_ФактРаботы]
  ADD CONSTRAINT [FK_ТО_ФактРаботы_UIDТО] FOREIGN KEY ([UIDТО]) REFERENCES [dbo].[ТО_Факт] ([UIDТО])
GO