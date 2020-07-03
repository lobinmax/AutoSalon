CREATE TABLE [dbo].[Заказы] (
  [UIDЗаказа] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Заказы_UIDЗаказа] DEFAULT (newid()) ROWGUIDCOL,
  [UIDТовара] [uniqueidentifier] NOT NULL,
  [СтоимостьАвто] [money] NOT NULL,
  [UIDКлиента] [uniqueidentifier] NOT NULL,
  [НомерЗаказа] [varchar](20) NOT NULL DEFAULT ([dbo].[ЗаказыГенераторНомера]()),
  [ДатаЗаказа] [date] NOT NULL,
  [IdСтатусаЗаказа] [tinyint] NOT NULL,
  [СуммаОплаты] [money] NOT NULL,
  [ДатаСоздания] [datetime] NOT NULL DEFAULT ([dbo].[DtТекущаяДатаВремя]()),
  [ДатаИзменения] [datetime] NOT NULL DEFAULT ([dbo].[DtТекущаяДатаВремя]()),
  [UIDАвтора] [uniqueidentifier] NOT NULL DEFAULT ([dbo].[ШтатПолучитьUIDСотрудника]()),
  [UIDИзменяющего] [uniqueidentifier] NOT NULL DEFAULT ([dbo].[ШтатПолучитьUIDСотрудника]()),
  CONSTRAINT [PK_Заказы_UIDЗаказа] PRIMARY KEY CLUSTERED ([UIDЗаказа])
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX [UK_Заказы]
  ON [dbo].[Заказы] ([UIDТовара], [UIDКлиента])
  ON [PRIMARY]
GO

CREATE UNIQUE INDEX [UK_Заказы_НомерЗаказа]
  ON [dbo].[Заказы] ([НомерЗаказа])
  ON [PRIMARY]
GO

ALTER TABLE [dbo].[Заказы]
  ADD CONSTRAINT [FK_Заказы_IdСтатусаЗаказа] FOREIGN KEY ([IdСтатусаЗаказа]) REFERENCES [dbo].[ЗаказыСтатусы] ([IdСтатусЗаказа])
GO

ALTER TABLE [dbo].[Заказы]
  ADD CONSTRAINT [FK_Заказы_UIDАвтора] FOREIGN KEY ([UIDАвтора]) REFERENCES [dbo].[ШтатСотрудники] ([UIDСотрудника])
GO

ALTER TABLE [dbo].[Заказы]
  ADD CONSTRAINT [FK_Заказы_UIDИзменяющего] FOREIGN KEY ([UIDИзменяющего]) REFERENCES [dbo].[ШтатСотрудники] ([UIDСотрудника])
GO

ALTER TABLE [dbo].[Заказы]
  ADD CONSTRAINT [FK_Заказы_UIDТовара] FOREIGN KEY ([UIDТовара]) REFERENCES [dbo].[ГаражАвто] ([UIDТовара])
GO

ALTER TABLE [dbo].[Заказы]
  ADD CONSTRAINT [FK_Заказы_КлиентыДанные_UIDКлиента] FOREIGN KEY ([UIDКлиента]) REFERENCES [dbo].[КлиентыДанные] ([UIDКлиента])
GO