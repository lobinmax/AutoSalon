CREATE TABLE [dbo].[ГаражСтатусАвто] (
  [IdСтатусАвто] [tinyint] IDENTITY (0, 1),
  [Наименование] [varchar](50) NOT NULL,
  CONSTRAINT [PK_ГаражСтатусАвто_IdСтатусАвто] PRIMARY KEY CLUSTERED ([IdСтатусАвто])
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX [UK_ГаражСтатусАвто_Наименование]
  ON [dbo].[ГаражСтатусАвто] ([Наименование])
  ON [PRIMARY]
GO