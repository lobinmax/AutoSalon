CREATE TABLE [dbo].[ГаражАвто] (
  [UIDТовара] [uniqueidentifier] NOT NULL CONSTRAINT [DF_ГаражАвто_UIDТовара] DEFAULT (newid()) ROWGUIDCOL,
  [UIDМарки] [uniqueidentifier] NOT NULL,
  [UIDМодели] [uniqueidentifier] NOT NULL,
  [UIDПоколения] [uniqueidentifier] NOT NULL,
  [UIDСтоимости] [uniqueidentifier] NOT NULL,
  [IdСтатусАвто] [tinyint] NOT NULL,
  [IdТипТоплива] [tinyint] NOT NULL,
  [IdТипПривода] [tinyint] NOT NULL,
  [IdТипКузова] [tinyint] NOT NULL,
  [IdТипРуля] [tinyint] NOT NULL,
  [IdТипКПП] [tinyint] NOT NULL,
  [UIDАвтора] [uniqueidentifier] NOT NULL DEFAULT ([dbo].[ШтатПолучитьUIDСотрудника]()),
  [UIDИзменяющего] [uniqueidentifier] NOT NULL DEFAULT ([dbo].[ШтатПолучитьUIDСотрудника]()),
  [ДатаСоздания] [datetime] NOT NULL DEFAULT ([dbo].[DtТекущаяДатаВремя]()),
  [ДатаИзменения] [datetime] NOT NULL DEFAULT ([dbo].[DtТекущаяДатаВремя]()),
  [ГодВыпуска] [varchar](4) NOT NULL,
  [Пробег] [int] NOT NULL DEFAULT (0),
  [ЦветRGB] [varchar](50) NULL,
  [VIN] [varchar](70) NOT NULL,
  [ОбъемДвигателя] [numeric](4, 1) NOT NULL,
  [МощностьДвигателя] [int] NOT NULL,
  [НомерКузова] [varchar](50) NULL,
  CONSTRAINT [PK_ГаражАвто_UIDТовара] PRIMARY KEY CLUSTERED ([UIDТовара])
)
ON [PRIMARY]
GO

ALTER TABLE [dbo].[ГаражАвто]
  ADD CONSTRAINT [FK_ГаражАвто_UIDИзменяющего] FOREIGN KEY ([UIDИзменяющего]) REFERENCES [dbo].[ШтатСотрудники] ([UIDСотрудника])
GO

ALTER TABLE [dbo].[ГаражАвто]
  ADD CONSTRAINT [FK_ГаражАвто_UIDМарки] FOREIGN KEY ([UIDМарки]) REFERENCES [dbo].[АвтоМарки] ([UIDМарки])
GO

ALTER TABLE [dbo].[ГаражАвто]
  ADD CONSTRAINT [FK_ГаражАвто_UIDМодели] FOREIGN KEY ([UIDМодели]) REFERENCES [dbo].[АвтоМодели] ([UIDМодели])
GO

ALTER TABLE [dbo].[ГаражАвто]
  ADD CONSTRAINT [FK_ГаражАвто_UIDПоколения] FOREIGN KEY ([UIDПоколения]) REFERENCES [dbo].[АвтоПоколение] ([UIDПоколения])
GO

ALTER TABLE [dbo].[ГаражАвто]
  ADD CONSTRAINT [FK_ГаражАвто_АвтоТипКПП_IdТипКПП] FOREIGN KEY ([IdТипКПП]) REFERENCES [dbo].[АвтоТипКПП] ([IdТипКПП])
GO

ALTER TABLE [dbo].[ГаражАвто]
  ADD CONSTRAINT [FK_ГаражАвто_АвтоТипКузова_IdТипКузова] FOREIGN KEY ([IdТипКузова]) REFERENCES [dbo].[АвтоТипКузова] ([IdТипКузова])
GO

ALTER TABLE [dbo].[ГаражАвто]
  ADD CONSTRAINT [FK_ГаражАвто_АвтоТипПривода_IdТипПривода] FOREIGN KEY ([IdТипПривода]) REFERENCES [dbo].[АвтоТипПривода] ([IdТипПривода])
GO

ALTER TABLE [dbo].[ГаражАвто]
  ADD CONSTRAINT [FK_ГаражАвто_АвтоТипРуля_IdТипРуля] FOREIGN KEY ([IdТипРуля]) REFERENCES [dbo].[АвтоТипРуля] ([IdТипРуля])
GO

ALTER TABLE [dbo].[ГаражАвто]
  ADD CONSTRAINT [FK_ГаражАвто_АвтоТипТоплива_IdТипТоплива] FOREIGN KEY ([IdТипТоплива]) REFERENCES [dbo].[АвтоТипТоплива] ([IdТипТоплива])
GO

ALTER TABLE [dbo].[ГаражАвто]
  ADD CONSTRAINT [FK_ГаражАвто_ГаражСтатусАвто_IdСтатусАвто] FOREIGN KEY ([IdСтатусАвто]) REFERENCES [dbo].[ГаражСтатусАвто] ([IdСтатусАвто])
GO

ALTER TABLE [dbo].[ГаражАвто]
  ADD CONSTRAINT [FK_ГаражАвто_ГаражСтоимостьАвто_UIDСтоимостиАвто] FOREIGN KEY ([UIDСтоимости]) REFERENCES [dbo].[ГаражСтоимостьАвто] ([UIDСтоимостиАвто])
GO

ALTER TABLE [dbo].[ГаражАвто]
  ADD CONSTRAINT [FK_ГаражАвто_ШтатСотрудники_UIDСотрудника] FOREIGN KEY ([UIDАвтора]) REFERENCES [dbo].[ШтатСотрудники] ([UIDСотрудника])
GO