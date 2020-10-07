CREATE TABLE [dbo].[ТО_ФактЗапчасти] (
  [UIDЗапчасти] [uniqueidentifier] NOT NULL DEFAULT (newid()),
  [UIDРаботы] [uniqueidentifier] NOT NULL,
  [UIDТО] [uniqueidentifier] NOT NULL,
  [IdЗапчасти] [int] NOT NULL,
  [Количество] [int] NOT NULL,
  [Стоимость] [money] NOT NULL,
  [ДатаСоздания] [datetime] NOT NULL DEFAULT ([dbo].[DtТекущаяДатаВремя]()),
  [UIDАвтора] [uniqueidentifier] NOT NULL DEFAULT ([dbo].[ШтатПолучитьUIDСотрудника]()),
  CONSTRAINT [PK_ТО_ФактЗапчасти_UIDЗапчасти] PRIMARY KEY CLUSTERED ([UIDЗапчасти])
)
ON [PRIMARY]
GO

ALTER TABLE [dbo].[ТО_ФактЗапчасти]
  ADD CONSTRAINT [FK_ТО_ФактЗапчасти_IdЗапчасти] FOREIGN KEY ([IdЗапчасти]) REFERENCES [dbo].[ТО_Запчасти] ([IdЗапчасти])
GO

ALTER TABLE [dbo].[ТО_ФактЗапчасти]
  ADD CONSTRAINT [FK_ТО_ФактЗапчасти_UIDАвтора] FOREIGN KEY ([UIDАвтора]) REFERENCES [dbo].[ШтатСотрудники] ([UIDСотрудника])
GO

ALTER TABLE [dbo].[ТО_ФактЗапчасти]
  ADD CONSTRAINT [FK_ТО_ФактЗапчасти_UIDРаботы] FOREIGN KEY ([UIDРаботы]) REFERENCES [dbo].[ТО_ФактРаботы] ([UIDРаботы])
GO

ALTER TABLE [dbo].[ТО_ФактЗапчасти]
  ADD CONSTRAINT [FK_ТО_ФактЗапчасти_UIDТО] FOREIGN KEY ([UIDТО]) REFERENCES [dbo].[ТО_Факт] ([UIDТО])
GO