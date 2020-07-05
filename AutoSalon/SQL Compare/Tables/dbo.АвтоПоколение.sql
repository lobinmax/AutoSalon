CREATE TABLE [dbo].[АвтоПоколение] (
  [UIDПоколения] [uniqueidentifier] NOT NULL CONSTRAINT [DF_АвтоПоколение_UIDПоколения] DEFAULT (newid()) ROWGUIDCOL,
  [UIDМодели] [uniqueidentifier] NOT NULL,
  [UIDМарки] [uniqueidentifier] NOT NULL,
  [Наименование] [varchar](150) NOT NULL,
  [НачалоПроизводства] [int] NOT NULL,
  [ОкончаниеПроизводства] [int] NULL,
  [IdТипКузова] [tinyint] NOT NULL,
  CONSTRAINT [PK_АвтоПоколение_UIDПоколения] PRIMARY KEY CLUSTERED ([UIDПоколения])
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX [UK_АвтоПоколение]
  ON [dbo].[АвтоПоколение] ([Наименование], [UIDМодели], [IdТипКузова])
  ON [PRIMARY]
GO

ALTER TABLE [dbo].[АвтоПоколение]
  ADD CONSTRAINT [FK_АвтоПоколение_IdТипКузова] FOREIGN KEY ([IdТипКузова]) REFERENCES [dbo].[АвтоТипКузова] ([IdТипКузова])
GO

ALTER TABLE [dbo].[АвтоПоколение]
  ADD CONSTRAINT [FK_АвтоПоколение_UIDМарки] FOREIGN KEY ([UIDМарки]) REFERENCES [dbo].[АвтоМарки] ([UIDМарки])
GO

ALTER TABLE [dbo].[АвтоПоколение]
  ADD CONSTRAINT [FK_АвтоПоколение_UIDМодели] FOREIGN KEY ([UIDМодели]) REFERENCES [dbo].[АвтоМодели] ([UIDМодели])
GO