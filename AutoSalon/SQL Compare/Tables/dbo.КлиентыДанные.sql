CREATE TABLE [dbo].[КлиентыДанные] (
  [UIDКлиента] [uniqueidentifier] NOT NULL CONSTRAINT [DF_КлиентыДанные_UIDКлиента] DEFAULT (newid()) ROWGUIDCOL,
  [Фамилия] [varchar](50) NOT NULL,
  [Имя] [varchar](50) NOT NULL,
  [Отчество] [varchar](50) NOT NULL,
  [ПД Серия] [varchar](4) NOT NULL,
  [ПД Номер] [varchar](6) NOT NULL,
  [ПД Дата выдачи] [date] NOT NULL,
  [ПД Кем выдан] [varchar](150) NOT NULL,
  [ПД Код подразделения] [varchar](7) NOT NULL,
  [ПД Дата рождения] [date] NOT NULL,
  [IdПола] [tinyint] NOT NULL,
  [Адрес регистрации] [varchar](250) NOT NULL,
  [Номер телефона] [varchar](20) NULL,
  [Email] [varchar](70) NULL,
  [Дата добавления] [datetime] NOT NULL DEFAULT ([dbo].[DtТекущаяДатаВремя]()),
  [Дата изменения] [datetime] NOT NULL DEFAULT ([dbo].[DtТекущаяДатаВремя]()),
  [UIDАвтора] [uniqueidentifier] NOT NULL DEFAULT ([dbo].[ШтатПолучитьUIDСотрудника]()),
  [UIDИзменяющего] [uniqueidentifier] NOT NULL DEFAULT ([dbo].[ШтатПолучитьUIDСотрудника]()),
  CONSTRAINT [PK_КлиентыДанные_UIDКлмента] PRIMARY KEY CLUSTERED ([UIDКлиента])
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX [IDX_КлиентыДанные]
  ON [dbo].[КлиентыДанные] ([Фамилия], [Имя], [Отчество], [ПД Дата рождения])
  ON [PRIMARY]
GO

ALTER TABLE [dbo].[КлиентыДанные]
  ADD CONSTRAINT [FK_КлиентыДанные_IdПола] FOREIGN KEY ([IdПола]) REFERENCES [dbo].[КлиентыПол] ([IdПола])
GO

ALTER TABLE [dbo].[КлиентыДанные]
  ADD CONSTRAINT [FK_КлиентыДанные_UIDАвтора] FOREIGN KEY ([UIDАвтора]) REFERENCES [dbo].[ШтатСотрудники] ([UIDСотрудника])
GO

ALTER TABLE [dbo].[КлиентыДанные]
  ADD CONSTRAINT [FK_КлиентыДанные_UIDИзменяющего] FOREIGN KEY ([UIDИзменяющего]) REFERENCES [dbo].[ШтатСотрудники] ([UIDСотрудника])
GO