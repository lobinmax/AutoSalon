CREATE TABLE [dbo].[АвтоТипКузова] (
  [IdТипКузова] [tinyint] IDENTITY (0, 1),
  [Наименование] [varchar](50) NOT NULL,
  CONSTRAINT [PK_АвтоТипКузова_IdТипКузова] PRIMARY KEY CLUSTERED ([IdТипКузова])
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX [UK_АвтоТипКузова_Наименование]
  ON [dbo].[АвтоТипКузова] ([Наименование])
  ON [PRIMARY]
GO