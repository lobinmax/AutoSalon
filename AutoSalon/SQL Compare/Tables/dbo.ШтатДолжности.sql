CREATE TABLE [dbo].[ШтатДолжности] (
  [IdДолжности] [int] IDENTITY (0, 1),
  [Наименование] [varchar](50) NOT NULL,
  [СервернаяРоль] [varchar](50) NOT NULL,
  CONSTRAINT [PK_ШтатДолжности_IdДолжности] PRIMARY KEY CLUSTERED ([IdДолжности])
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX [UK_ШтатДолжности_Наименование]
  ON [dbo].[ШтатДолжности] ([Наименование])
  ON [PRIMARY]
GO