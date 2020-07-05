CREATE TABLE [dbo].[ГаражСтоимостьАвто] (
  [UIDСтоимостиАвто] [uniqueidentifier] NOT NULL CONSTRAINT [DF_ГаражСтоимостьАвто_UIDСтоимостиАвто] DEFAULT (newid()) ROWGUIDCOL,
  [UIDТовара] [uniqueidentifier] NOT NULL,
  [Стоимость] [money] NOT NULL,
  [ДатаСтоимости] [datetime] NOT NULL,
  [ДатаСоздания] [datetime] NOT NULL DEFAULT ([dbo].[DtТекущаяДатаВремя]()),
  [ДатаИзменения] [datetime] NOT NULL DEFAULT ([dbo].[DtТекущаяДатаВремя]()),
  [UIDАвтора] [uniqueidentifier] NOT NULL DEFAULT ([dbo].[ШтатПолучитьUIDСотрудника]()),
  [UIDИзменяющего] [uniqueidentifier] NOT NULL DEFAULT ([dbo].[ШтатПолучитьUIDСотрудника]()),
  CONSTRAINT [PK_ГаражСтоимостьАвто_UIDСтоимостиАвто] PRIMARY KEY CLUSTERED ([UIDСтоимостиАвто])
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX [UK_ГаражСтоимостьАвто]
  ON [dbo].[ГаражСтоимостьАвто] ([UIDТовара], [ДатаСтоимости])
  ON [PRIMARY]
GO

ALTER TABLE [dbo].[ГаражСтоимостьАвто]
  ADD CONSTRAINT [FK_ГаражСтоимостьАвто_UIDАвтора] FOREIGN KEY ([UIDАвтора]) REFERENCES [dbo].[ШтатСотрудники] ([UIDСотрудника])
GO

ALTER TABLE [dbo].[ГаражСтоимостьАвто]
  ADD CONSTRAINT [FK_ГаражСтоимостьАвто_UIDИзменяющего] FOREIGN KEY ([UIDИзменяющего]) REFERENCES [dbo].[ШтатСотрудники] ([UIDСотрудника])
GO

ALTER TABLE [dbo].[ГаражСтоимостьАвто]
  ADD CONSTRAINT [FK_ГаражСтоимостьАвто_UIDТовара] FOREIGN KEY ([UIDТовара]) REFERENCES [dbo].[ГаражАвто] ([UIDТовара])
GO