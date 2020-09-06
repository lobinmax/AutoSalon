CREATE TABLE [dbo].[ТО_ФактРаботы] (
  [UIDРаботы] [uniqueidentifier] NOT NULL DEFAULT (newid()),
  CONSTRAINT [PK_ТО_ФактРаботы_UIDРаботы] PRIMARY KEY CLUSTERED ([UIDРаботы])
)
ON [PRIMARY]
GO