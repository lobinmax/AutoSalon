CREATE TABLE [dbo].[КлиентыПол] (
  [IdПола] [tinyint] IDENTITY,
  [Наименование] [varchar](50) NOT NULL,
  CONSTRAINT [PK_Пол_IdПол] PRIMARY KEY CLUSTERED ([IdПола])
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX [UK_Пол_Наименование]
  ON [dbo].[КлиентыПол] ([Наименование])
  ON [PRIMARY]
GO