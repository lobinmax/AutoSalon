CREATE TABLE [dbo].[Страны] (
  [UIDСтраны] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Страны_UIDСтраны] DEFAULT (newid()) ROWGUIDCOL,
  [Наименование] [varchar](150) NOT NULL,
  [Наименование сокр.] [varchar](20) NOT NULL,
  CONSTRAINT [PK_Страны_UIDСтраны] PRIMARY KEY CLUSTERED ([UIDСтраны])
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX [UK_Страны]
  ON [dbo].[Страны] ([Наименование], [Наименование сокр.])
  ON [PRIMARY]
GO