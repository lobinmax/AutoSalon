CREATE TABLE [dbo].[АвтоТипРуля] (
  [IdТипРуля] [tinyint] IDENTITY (0, 1),
  [Наименование] [varchar](50) NOT NULL,
  CONSTRAINT [PK_АвтоТипРуля_IdТипРуля] PRIMARY KEY CLUSTERED ([IdТипРуля])
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX [UK_АвтоТипРуля_Наименование]
  ON [dbo].[АвтоТипРуля] ([Наименование])
  ON [PRIMARY]
GO