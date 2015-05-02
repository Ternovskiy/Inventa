--подключение к серверу (LocalDb)\v11.0

PRINT N'Creating [dbo].[Тип журнала]';
GO
CREATE TABLE [dbo].[Тип журнала] (
    [Код]      INT          IDENTITY (1, 1)     NOT NULL,
    [Название] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Тип журнала] PRIMARY KEY CLUSTERED ([Код] ASC)
);

GO
PRINT N'Creating [dbo].[Тип лога]';
GO
CREATE TABLE [dbo].[Тип лога] (
    [Код]      INT            IDENTITY (1, 1)   NOT NULL,
    [Название] NVARCHAR (50) NOT NULL,
    [Описание] NVARCHAR (50) NULL,
    CONSTRAINT [PK_Тип лога] PRIMARY KEY CLUSTERED ([Код] ASC)
);

GO
PRINT N'Creating [dbo].[Тип населенного пункта]';
GO
CREATE TABLE [dbo].[Тип населенного пункта] (
    [Код]      INT          IDENTITY (1, 1)     NOT NULL,
    [Название] NVARCHAR (50) NULL,
    CONSTRAINT [PK_Тип населенного пункта] PRIMARY KEY CLUSTERED ([Код] ASC)
);

GO
PRINT N'Creating [dbo].[Тип показателя]';
GO
CREATE TABLE [dbo].[Тип показателя] (
    [Код]      INT        IDENTITY (1, 1)       NOT NULL,
    [Название] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Тип показателя] PRIMARY KEY CLUSTERED ([Код] ASC)
);

GO
PRINT N'Creating [dbo].[Тип работ]';
GO
CREATE TABLE [dbo].[Тип работ] (
    [Код]      INT          IDENTITY (1, 1)     NOT NULL,
    [Название] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Тип работ] PRIMARY KEY CLUSTERED ([Код] ASC)
);

GO
PRINT N'Creating [dbo].[Тип улицы]';
GO
CREATE TABLE [dbo].[Тип улицы] (
    [Код]      INT           IDENTITY (1, 1)    NOT NULL,
    [Название] NVARCHAR (50) NULL,
    CONSTRAINT [PK_Тип улицы] PRIMARY KEY CLUSTERED ([Код] ASC)
);

GO
PRINT N'Creating [dbo].[Тип юр. лица]';
GO
CREATE TABLE [dbo].[Тип юр. лица] (
    [Код]      INT           IDENTITY (1, 1)     NOT NULL,
    [Название] NVARCHAR (50)  NOT NULL,
    [Описание] NVARCHAR (200) NULL,
    CONSTRAINT [PK_Тип юр. лица] PRIMARY KEY CLUSTERED ([Код] ASC)
);

GO
PRINT N'Creating [dbo].[Населенный пункт]';
GO
CREATE TABLE [dbo].[Населенный пункт] (
    [Код]      INT          IDENTITY (1, 1)     NOT NULL,
    [Название] NVARCHAR (50) NOT NULL,
    [Код типа] INT           NOT NULL,
    CONSTRAINT [PK_Населенный пункт] PRIMARY KEY CLUSTERED ([Код] ASC),
    CONSTRAINT [FK_Населенный пункт_Тип населенного пункта] FOREIGN KEY ([Код типа]) REFERENCES [dbo].[Тип населенного пункта] ([Код])
);

GO
PRINT N'Creating [dbo].[Улица]';
GO
CREATE TABLE [dbo].[Улица] (
    [Код]      INT          IDENTITY (1, 1)     NOT NULL,
    [Название] NVARCHAR (50) NOT NULL,
    [Код типа] INT           NOT NULL,
    CONSTRAINT [PK_Улица] PRIMARY KEY CLUSTERED ([Код] ASC),
    CONSTRAINT [FK_Улица_Тип улицы] FOREIGN KEY ([Код типа]) REFERENCES [dbo].[Тип улицы] ([Код])
);


GO
PRINT N'Creating [dbo].[Вид показателя]';
GO
CREATE TABLE [dbo].[Вид показателя] (
    [Код]      INT           IDENTITY (1, 1)     NOT NULL,
    [Название] NVARCHAR (50)  NOT NULL,
    [Описание] NVARCHAR (150) NULL,
    CONSTRAINT [PK_Вид показателя] PRIMARY KEY CLUSTERED ([Код] ASC)
);


GO
PRINT N'Creating [dbo].[Физическое лицо]';
GO
CREATE TABLE [dbo].[Физическое лицо] (
    [Код]      INT           IDENTITY (1, 1)    NOT NULL,
    [Фамилия]  NVARCHAR (50) NOT NULL,
    [Имя]      NVARCHAR (50) NOT NULL,
    [Отчество] NVARCHAR (50) NOT NULL,
    [Телефон]  NVARCHAR (50) NULL,
    CONSTRAINT [PK_Физическое лицо] PRIMARY KEY CLUSTERED ([Код] ASC)
);


GO
PRINT N'Creating [dbo].[Адрес]';
GO
CREATE TABLE [dbo].[Адрес] (
    [Код]                  INT    IDENTITY (1, 1) NOT NULL,
    [Номер дома]           INT NOT NULL,
    [Код улицы]            INT NOT NULL,
    [Код нас пункта]       INT NOT NULL,
    [Код физического лица] INT NULL,
    CONSTRAINT [PK_Адрес] PRIMARY KEY CLUSTERED ([Код] ASC),
    CONSTRAINT [FK_Адрес_Улица] FOREIGN KEY ([Код улицы]) REFERENCES [dbo].[Улица] ([Код]),
    CONSTRAINT [FK_Адрес_Населенный пункт] FOREIGN KEY ([Код нас пункта]) REFERENCES [dbo].[Населенный пункт] ([Код]),
    CONSTRAINT [FK_Адрес_Физическое лицо] FOREIGN KEY ([Код физического лица]) REFERENCES [dbo].[Физическое лицо] ([Код])
);


GO
PRINT N'Creating [dbo].[Должность]';
GO
CREATE TABLE [dbo].[Должность] (
    [Код]              INT          IDENTITY (1, 1)     NOT NULL,
    [Название]         NVARCHAR (50) NOT NULL,
    [Краткое название] NVARCHAR (50) NULL,
    CONSTRAINT [PK_Должность] PRIMARY KEY CLUSTERED ([Код] ASC)
);

GO
PRINT N'Creating [dbo].[Единицы измерения]';
GO
CREATE TABLE [dbo].[Единицы измерения] (
    [Код]              INT        IDENTITY (1, 1)       NOT NULL,
    [Название]         NVARCHAR (50) NOT NULL,
    [Краткое название] NCHAR (10)    NULL,
    CONSTRAINT [PK_Единицы измерения] PRIMARY KEY CLUSTERED ([Код] ASC)
);

GO
PRINT N'Creating [dbo].[Журнал]';
GO
CREATE TABLE [dbo].[Журнал] (
    [Номер]    INT         IDENTITY (1, 1)      NOT NULL,
    [Название] NVARCHAR (50) NULL,
    [Код типа] INT           NOT NULL,
    CONSTRAINT [PK_Журнал] PRIMARY KEY CLUSTERED ([Номер] ASC),
    CONSTRAINT [FK_Журнал_Тип журнала] FOREIGN KEY ([Код типа]) REFERENCES [dbo].[Тип журнала] ([Код])
);

GO
PRINT N'Creating [dbo].[Оборудование]';
GO
CREATE TABLE [dbo].[Оборудование] (
    [Номер]             INT           IDENTITY (1, 1)     NOT NULL,
    [Дата изготовления] DATE           NOT NULL,
    [Описание]          NVARCHAR (150) NULL,
    [Код юр. лица]      INT            NOT NULL,
    CONSTRAINT [PK_Оборудование] PRIMARY KEY CLUSTERED ([Номер] ASC),
	CONSTRAINT [FK_Оборудование_Юридическое лицо] FOREIGN KEY ([Код юр. лица]) REFERENCES [dbo].[Юридическое лицо] ([Код])
);




GO
PRINT N'Creating [dbo].[Состояние оборудования]';
GO
CREATE TABLE [dbo].[Состояние оборудования] (
    [Номер] INT    IDENTITY (1, 1) NOT NULL,
    CONSTRAINT [PK_Состояние оборудования] PRIMARY KEY CLUSTERED ([Номер] ASC)
);

GO
PRINT N'Creating [dbo].[Показатель]';
GO
CREATE TABLE [dbo].[Показатель] (
    [Код]                 INT          IDENTITY (1, 1)     NOT NULL,
    [Значение]            NVARCHAR (50) NULL,
    [Код показателя]      INT           NULL,
    [Код состояния]       INT           NULL,
    [Код оборудование]    INT           NULL,
    [Тип показателя]      INT           NOT NULL,
    [Код вида показателя] INT           NOT NULL,
    [Единицы измерения]   INT           NULL,
    CONSTRAINT [PK_Показатель] PRIMARY KEY CLUSTERED ([Код] ASC),
    CONSTRAINT [FK_Показатель_Показатель] FOREIGN KEY ([Код показателя]) REFERENCES [dbo].[Показатель] ([Код]),
    CONSTRAINT [FK_Показатель_Единицы измерения] FOREIGN KEY ([Единицы измерения]) REFERENCES [dbo].[Единицы измерения] ([Код]),
    CONSTRAINT [FK_Показатель_Тип показателя] FOREIGN KEY ([Тип показателя]) REFERENCES [dbo].[Тип показателя] ([Код]),
    CONSTRAINT [FK_Показатель_Вид показателя] FOREIGN KEY ([Код вида показателя]) REFERENCES [dbo].[Вид показателя] ([Код]),
    CONSTRAINT [FK_Показатель_Состояние оборудования] FOREIGN KEY ([Код состояния]) REFERENCES [dbo].[Состояние оборудования] ([Номер]),
    CONSTRAINT [FK_Показатель_Оборудование] FOREIGN KEY ([Код оборудование]) REFERENCES [dbo].[Оборудование] ([Номер])
);


GO
PRINT N'Creating [dbo].[Тег]';
GO
CREATE TABLE [dbo].[Тег] (
    [Код]      INT         IDENTITY (1, 1)   NOT NULL,
    [Название] NCHAR (10) NOT NULL,
    [Описание] NCHAR (10) NULL,
    CONSTRAINT [PK_Тег] PRIMARY KEY CLUSTERED ([Код] ASC)
);


GO
PRINT N'Creating [dbo].[Лог]';
GO
CREATE TABLE [dbo].[Лог] (
    [Номер]     INT            IDENTITY (1, 1)   NOT NULL,
    [Сообщение] NVARCHAR (50) NOT NULL,
    [Код тега]  INT           NOT NULL,
    [Код лога]  INT           NOT NULL,
    CONSTRAINT [PK_Лог] PRIMARY KEY CLUSTERED ([Номер] ASC),
    CONSTRAINT [FK_Лог_Тег] FOREIGN KEY ([Код тега]) REFERENCES [dbo].[Тег] ([Код]),
    CONSTRAINT [FK_Лог_Тип лога] FOREIGN KEY ([Код лога]) REFERENCES [dbo].[Тип лога] ([Код])
);




GO
PRINT N'Creating [dbo].[Хост]';
GO
CREATE TABLE [dbo].[Хост] (
    [Номер]      INT            IDENTITY (1, 1)    NOT NULL,
    [IP-адрес]   NVARCHAR (50)  NOT NULL,
    [Описание]   NVARCHAR (150) NULL,
    [Код адреса] INT            NOT NULL,
    CONSTRAINT [PK_Хост] PRIMARY KEY CLUSTERED ([Номер] ASC),
    CONSTRAINT [FK_Хост_Адрес] FOREIGN KEY ([Код адреса]) REFERENCES [dbo].[Адрес] ([Код])
);

GO
PRINT N'Creating [dbo].[Событие]';
GO
CREATE TABLE [dbo].[Событие] (
    [Код]           INT            IDENTITY (1, 1)    NOT NULL,
    [Дата]          DATE           NOT NULL,
    [Описание]      NVARCHAR (150) NULL,
    [Код журнала]   INT            NOT NULL,
    [Код хоста]     INT            NOT NULL,
    [Код лога]      INT            NULL,
    [Код состояния] INT            NULL,
    CONSTRAINT [PK_Событие] PRIMARY KEY CLUSTERED ([Код] ASC),
    CONSTRAINT [FK_Событие_Журнал] FOREIGN KEY ([Код журнала]) REFERENCES [dbo].[Журнал] ([Номер]),
    CONSTRAINT [FK_Событие_Хост] FOREIGN KEY ([Код хоста]) REFERENCES [dbo].[Хост] ([Номер]),
    CONSTRAINT [FK_Событие_Лог] FOREIGN KEY ([Код лога]) REFERENCES [dbo].[Лог] ([Номер]),
    CONSTRAINT [FK_Событие_Состояние оборудования] FOREIGN KEY ([Код состояния]) REFERENCES [dbo].[Состояние оборудования] ([Номер])
);




GO
PRINT N'Creating [dbo].[Юридическое лицо]';
GO
CREATE TABLE [dbo].[Юридическое лицо] (
    [Код]              INT           IDENTITY (1, 1)    NOT NULL,
    [Название]         NVARCHAR (50) NOT NULL,
    [Краткое название] NVARCHAR (50) NOT NULL,
    [Телефон]          NVARCHAR (50) NULL,
    [Код типа]         INT           NOT NULL,
    [Код юрид. лица]   INT           NULL,
    CONSTRAINT [PK_Юридическое лицо] PRIMARY KEY CLUSTERED ([Код] ASC),
    CONSTRAINT [FK_Юридическое лицо_Тип юр. лица] FOREIGN KEY ([Код типа]) REFERENCES [dbo].[Тип юр. лица] ([Код]),
    CONSTRAINT [FK_Юридическое лицо_Юридическое лицо] FOREIGN KEY ([Код юрид. лица]) REFERENCES [dbo].[Юридическое лицо] ([Код])
);



GO
PRINT N'Creating [dbo].[Фр. труд. договора]';
GO
CREATE TABLE [dbo].[Фр. труд. договора] (
    [Номер]           INT    IDENTITY (1, 1)  NOT NULL,
    [Дата приема]     DATE NOT NULL,
    [Дата увольнения] DATE NULL,
    [Код физ. лица]   INT  NOT NULL,
    [Код юр. лица]    INT  NOT NULL,
    [Код должности]   INT  NOT NULL,
    CONSTRAINT [PK_Фр. труд. договора] PRIMARY KEY CLUSTERED ([Номер] ASC),
    CONSTRAINT [FK_Фр. труд. договора_Должность] FOREIGN KEY ([Код должности]) REFERENCES [dbo].[Должность] ([Код]),
    CONSTRAINT [FK_Фр. труд. договора_Юридическое лицо] FOREIGN KEY ([Код юр. лица]) REFERENCES [dbo].[Юридическое лицо] ([Код]),
    CONSTRAINT [FK_Фр. труд. договора_Физическое лицо] FOREIGN KEY ([Код физ. лица]) REFERENCES [dbo].[Физическое лицо] ([Код])
);


GO
PRINT N'Creating [dbo].[Документ работ]';
GO
CREATE TABLE [dbo].[Документ работ] (
    [Номер]              INT            IDENTITY (1, 1)    NOT NULL,
    [Название]           NVARCHAR (50)  NOT NULL,
    [Дата]               DATE           NOT NULL,
    [Описание]           NVARCHAR (150) NULL,
    [Код хоста]          INT            NOT NULL,
    [Код фр. труд. дог.] INT            NOT NULL,
    [Код типа]           INT            NOT NULL,
    [Код оборудования]   INT            NOT NULL,
    CONSTRAINT [PK_Документ работ] PRIMARY KEY CLUSTERED ([Номер] ASC),
    CONSTRAINT [FK_Документ работ_Оборудование] FOREIGN KEY ([Код оборудования]) REFERENCES [dbo].[Оборудование] ([Номер]),
    CONSTRAINT [FK_Документ работ_Тип работ] FOREIGN KEY ([Код типа]) REFERENCES [dbo].[Тип работ] ([Код]),
    CONSTRAINT [FK_Документ работ_Фр. труд. договора] FOREIGN KEY ([Код фр. труд. дог.]) REFERENCES [dbo].[Фр. труд. договора] ([Номер]),
    CONSTRAINT [FK_Документ работ_Хост] FOREIGN KEY ([Код хоста]) REFERENCES [dbo].[Хост] ([Номер])
);
