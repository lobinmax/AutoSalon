CREATE TABLE [dbo].[ТО_График] (
  [IdТО] [tinyint] IDENTITY (0, 1),
  [Наименование] [varchar](150) NOT NULL,
  [СрокГод] [int] NULL,
  [СрокМесяц] [int] NULL,
  CONSTRAINT [PK_ТО_График_IdТО] PRIMARY KEY CLUSTERED ([IdТО])
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX [UK_ТО_График_Наименование]
  ON [dbo].[ТО_График] ([Наименование])
  ON [PRIMARY]
GO