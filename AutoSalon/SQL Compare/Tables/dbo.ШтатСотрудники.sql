CREATE TABLE [dbo].[ШтатСотрудники] (
  [UIDСотрудника] [uniqueidentifier] NOT NULL CONSTRAINT [DF_ШтатСотрудники_UIDСотрудника] DEFAULT (newid()) ROWGUIDCOL,
  [Логин] [varchar](50) NOT NULL,
  [Фамилия] [varchar](100) NOT NULL,
  [Имя] [varchar](100) NOT NULL,
  [Отчество] [varchar](100) NOT NULL,
  [Дата рождения] [date] NULL,
  [IdДолжности] [int] NOT NULL,
  [ДатаСоздания] [datetime] NOT NULL CONSTRAINT [DF__ШтатСотру__ДатаС__1E6F845E] DEFAULT ([dbo].[DtТекущаяДатаВремя]()),
  [ДатаИзменения] [datetime] NOT NULL CONSTRAINT [DF__ШтатСотру__ДатаИ__45F365D3] DEFAULT ([dbo].[DtТекущаяДатаВремя]()),
  [UIDАвтора] [uniqueidentifier] NOT NULL DEFAULT ([dbo].[ШтатПолучитьUIDСотрудника]()),
  [UIDИзменяющего] [uniqueidentifier] NOT NULL DEFAULT ([dbo].[ШтатПолучитьUIDСотрудника]()),
  [Телефон] [varchar](30) NULL,
  [Email] [varchar](100) NULL,
  [IdПола] [tinyint] NOT NULL,
  [Домен] [varchar](100) NOT NULL CONSTRAINT [DF__ШтатСотру__Домен__16CE6296] DEFAULT (''),
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