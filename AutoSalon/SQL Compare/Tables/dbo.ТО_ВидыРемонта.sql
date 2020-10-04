CREATE TABLE [dbo].[ТО_ВидыРемонта] (
  [IdВидаРемонта] [int] IDENTITY (0, 1),
  [Наименование] [varchar](200) NOT NULL,
  [Стоимость] [money] NOT NULL,
  CONSTRAINT [PK_ТО_ВидыРемонта_IdВидаРемонта] PRIMARY KEY CLUSTERED ([IdВидаРемонта])
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX [UK_ТО_ВидыРемонта_Наименование]
  ON [dbo].[ТО_ВидыРемонта] ([Наименование])
  ON [PRIMARY]
GO