CREATE TABLE [dbo].[ЗаказыСтатусы] (
  [IdСтатусЗаказа] [tinyint] IDENTITY (0, 1),
  [Наименование] [varchar](50) NOT NULL,
  CONSTRAINT [PK_ЗаказыСтатусы_IdСтатусЗаказа] PRIMARY KEY CLUSTERED ([IdСтатусЗаказа])
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX [UK_ЗаказыСтатусы_Наименование]
  ON [dbo].[ЗаказыСтатусы] ([Наименование])
  ON [PRIMARY]
GO