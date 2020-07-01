CREATE TABLE [dbo].[АвтоМарки] (
  [UIDМарки] [uniqueidentifier] NOT NULL CONSTRAINT [DF_АвтоМарки_UIDМарки] DEFAULT (newid()) ROWGUIDCOL,
  [Наименование] [varchar](150) NOT NULL,
  [UIDСтранаПроизводитель] [uniqueidentifier] NOT NULL,
  CONSTRAINT [PK_АвтоМарки_UIDМарки] PRIMARY KEY CLUSTERED ([UIDМарки])
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX [UK_АвтоМарки]
  ON [dbo].[АвтоМарки] ([Наименование], [UIDСтранаПроизводитель])
  ON [PRIMARY]
GO

ALTER TABLE [dbo].[АвтоМарки]
  ADD CONSTRAINT [FK_АвтоМарки_UIDСтранаПроизводитель] FOREIGN KEY ([UIDСтранаПроизводитель]) REFERENCES [dbo].[Страны] ([UIDСтраны])
GO