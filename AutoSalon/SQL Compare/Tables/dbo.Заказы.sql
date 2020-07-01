CREATE TABLE [dbo].[Заказы] (
  [UIDЗаказа] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Заказы_UIDЗаказа] DEFAULT (newid()) ROWGUIDCOL,
  [UIDТовара] [uniqueidentifier] NOT NULL,
  [UIDСтоимости] [uniqueidentifier] NOT NULL,
  [UIDКлиента] [uniqueidentifier] NOT NULL,
  [ДатаЗаказа] [datetime] NOT NULL,
  [IdСтатусаЗаказа] [tinyint] NOT NULL,
  [СуммаОплаты] [money] NOT NULL,
  [ДатаСоздания] [datetime] NOT NULL,
  [ДатаИзменения] [datetime] NOT NULL,
  [UIDАвтора] [uniqueidentifier] NOT NULL,
  [UIDИзменяющего] [uniqueidentifier] NOT NULL,
  CONSTRAINT [PK_Заказы_UIDЗаказа] PRIMARY KEY CLUSTERED ([UIDЗаказа])
)
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
  ADD CONSTRAINT [FK_Заказы_КлиентыДанные_UIDКлиента] FOREIGN KEY ([UIDКлиента]) REFERENCES [dbo].[КлиентыДанные] ([UIDКлиента])
GO