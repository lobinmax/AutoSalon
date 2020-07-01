CREATE TABLE [dbo].[АвтоТипТоплива] (
  [IdТипТоплива] [tinyint] IDENTITY (0, 1),
  [Наименование] [varchar](50) NOT NULL,
  CONSTRAINT [PK_АвтоТипТоплива_IdТипТоплива] PRIMARY KEY CLUSTERED ([IdТипТоплива])
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX [UK_АвтоТипТоплива_Наименование]
  ON [dbo].[АвтоТипТоплива] ([Наименование])
  ON [PRIMARY]
GO