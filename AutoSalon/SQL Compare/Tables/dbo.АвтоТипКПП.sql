CREATE TABLE [dbo].[АвтоТипКПП] (
  [IdТипКПП] [tinyint] IDENTITY (0, 1),
  [Наименование] [varchar](50) NOT NULL,
  [Наименование сокр.] [varchar](50) NOT NULL,
  CONSTRAINT [PK_АвтоТипКПП_IdТипКПП] PRIMARY KEY CLUSTERED ([IdТипКПП])
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX [UK_АвтоТипКПП]
  ON [dbo].[АвтоТипКПП] ([Наименование], [Наименование сокр.])
  ON [PRIMARY]
GO