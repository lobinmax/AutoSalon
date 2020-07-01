CREATE TABLE [dbo].[АвтоТипПривода] (
  [IdТипПривода] [tinyint] IDENTITY (0, 1),
  [Наименование] [varchar](50) NOT NULL,
  CONSTRAINT [PK_АвтоТипПривода_IdТипПривода] PRIMARY KEY CLUSTERED ([IdТипПривода])
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX [UK_АвтоТипПривода_Наименование]
  ON [dbo].[АвтоТипПривода] ([Наименование])
  ON [PRIMARY]
GO