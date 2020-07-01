CREATE TABLE [dbo].[ШтатСотрудники] (
  [UIDСотрудника] [uniqueidentifier] NOT NULL CONSTRAINT [DF_ШтатСотрудники_UIDСотрудника] DEFAULT (newid()) ROWGUIDCOL,
  [Логин] [varchar](50) NOT NULL,
  [Фамилия] [varchar](100) NOT NULL,
  [Имя] [varchar](100) NOT NULL,
  [Отчество] [varchar](100) NOT NULL,
  [Дата рождения] [date] NULL,
  [IdДолжности] [int] NOT NULL,
  [ДатаСоздания] [datetime] NOT NULL,
  [ДатаИзменения] [datetime] NOT NULL DEFAULT ([dbo].[DtТекущаяДатаВремя]()),
  [UIDАвтора] [uniqueidentifier] NULL,
  [UIDИзменяющего] [uniqueidentifier] NOT NULL DEFAULT ([dbo].[ШтатПолучитьUIDСотрудника]()),
  [Телефон] [varchar](30) NULL,
  [Email] [varchar](100) NULL,
  [IdПола] [tinyint] NOT NULL,
  CONSTRAINT [PK_Сотрудники_UIDСотрудника] PRIMARY KEY CLUSTERED ([UIDСотрудника])
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX [UK_Сотрудники]
  ON [dbo].[ШтатСотрудники] ([Фамилия], [Имя], [Отчество], [Дата рождения])
  ON [PRIMARY]
GO

CREATE UNIQUE INDEX [UK_Сотрудники_Логин]
  ON [dbo].[ШтатСотрудники] ([Логин])
  ON [PRIMARY]
GO

ALTER TABLE [dbo].[ШтатСотрудники]
  ADD CONSTRAINT [FK_ШтатСотрудники_IdДолжности] FOREIGN KEY ([IdДолжности]) REFERENCES [dbo].[ШтатДолжности] ([IdДолжности])
GO

ALTER TABLE [dbo].[ШтатСотрудники]
  ADD CONSTRAINT [FK_ШтатСотрудники_IdПола] FOREIGN KEY ([IdПола]) REFERENCES [dbo].[КлиентыПол] ([IdПола])
GO