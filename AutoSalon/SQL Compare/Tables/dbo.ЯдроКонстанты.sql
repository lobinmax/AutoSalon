CREATE TABLE [dbo].[ЯдроКонстанты] (
  [Наименование] [varchar](150) NOT NULL,
  [Значение] [sql_variant] NOT NULL
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX [UK_ЯдроКонстанты_Наименование]
  ON [dbo].[ЯдроКонстанты] ([Наименование])
  ON [PRIMARY]
GO