CREATE TABLE [dbo].[ТО_ФактЗапчасти] (
  [UIDЗапчасти] [uniqueidentifier] NOT NULL DEFAULT (newid()),
  CONSTRAINT [PK_ТО_ФактЗапчасти_UIDЗапчасти] PRIMARY KEY CLUSTERED ([UIDЗапчасти])
)
ON [PRIMARY]
GO