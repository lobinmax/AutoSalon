CREATE TABLE [dbo].[АвтоМодели] (
  [UIDМодели] [uniqueidentifier] NOT NULL DEFAULT (newid()) ROWGUIDCOL,
  [UIDМарки] [uniqueidentifier] NOT NULL,
  [Наименование] [varchar](100) NOT NULL,
  [НачалоПроизводства] [varchar](4) NOT NULL,
  [ОкончаниеПроизводства] [varchar](4) NULL,
  CONSTRAINT [PK_АвтоМодели_UIDМодели] PRIMARY KEY CLUSTERED ([UIDМодели])
)
ON [PRIMARY]
GO

CREATE INDEX [IDX_АвтоМодели_НачалоПроизводства]
  ON [dbo].[АвтоМодели] ([НачалоПроизводства])
  ON [PRIMARY]
GO

CREATE UNIQUE INDEX [UK_АвтоМодели]
  ON [dbo].[АвтоМодели] ([Наименование], [UIDМарки])
  ON [PRIMARY]
GO

ALTER TABLE [dbo].[АвтоМодели]
  ADD CONSTRAINT [FK_АвтоМодели_UIDМарки] FOREIGN KEY ([UIDМарки]) REFERENCES [dbo].[АвтоМарки] ([UIDМарки])
GO