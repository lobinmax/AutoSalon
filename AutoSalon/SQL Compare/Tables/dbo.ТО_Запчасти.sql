CREATE TABLE [dbo].[ТО_Запчасти] (
  [IdЗапчасти] [int] IDENTITY,
  [Наименование] [varchar](150) NOT NULL,
  [Стоимость] [money] NOT NULL,
  CONSTRAINT [PK_ТО_Запчасти_IdЗапчасти] PRIMARY KEY CLUSTERED ([IdЗапчасти])
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX [UK_ТО_Запчасти_Наименование]
  ON [dbo].[ТО_Запчасти] ([Наименование])
  ON [PRIMARY]
GO