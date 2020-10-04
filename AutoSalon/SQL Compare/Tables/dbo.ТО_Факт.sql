CREATE TABLE [dbo].[ТО_Факт] (
  [UIDТО] [uniqueidentifier] NOT NULL DEFAULT (newid()),
  [UIDТовара] [uniqueidentifier] NOT NULL,
  [ТО_Наименование] [varchar](150) NOT NULL,
  [ДатаПлан] [date] NOT NULL,
  [ДатаФакт] [date] NULL,
  [UIDАвтора] [uniqueidentifier] NOT NULL DEFAULT ([dbo].[ШтатПолучитьUIDСотрудника]()),
  [ДатаСоздания] [datetime] NOT NULL DEFAULT ([dbo].[DtТекущаяДатаВремя]()),
  CONSTRAINT [PK_ТО_UIDТО] PRIMARY KEY CLUSTERED ([UIDТО])
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX [UK_ТО]
  ON [dbo].[ТО_Факт] ([UIDТовара], [ТО_Наименование])
  ON [PRIMARY]
GO

ALTER TABLE [dbo].[ТО_Факт]
  ADD CONSTRAINT [FK_ТО_UIDАвтора] FOREIGN KEY ([UIDАвтора]) REFERENCES [dbo].[ШтатСотрудники] ([UIDСотрудника])
GO

ALTER TABLE [dbo].[ТО_Факт]
  ADD CONSTRAINT [FK_ТО_UIDТовара] FOREIGN KEY ([UIDТовара]) REFERENCES [dbo].[ГаражАвто] ([UIDТовара])
GO