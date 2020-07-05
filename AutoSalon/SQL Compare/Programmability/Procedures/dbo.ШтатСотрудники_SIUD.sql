SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO

CREATE PROCEDURE [dbo].[ШтатСотрудники_SIUD] @UIDСотрудника UNIQUEIDENTIFIER = NULL,
@Логин VARCHAR(100) = NULL,
@Домен VARCHAR(100) = NULL,
@Фамилия VARCHAR(200) = NULL,
@Имя VARCHAR(200) = NULL,
@Отчество VARCHAR(200) = NULL,
@ДатаРождения DATE = NULL,
@Телефон VARCHAR(100) = NULL,
@Email VARCHAR(100) = NULL,
@IdПола TINYINT = NULL,
@IdДолжности INT = NULL,

@Function TINYINT = 0 -- 0 - источник данных формы
AS
BEGIN
    SET NOCOUNT ON
    SET XACT_ABORT ON

    DECLARE @RoleOld AS VARCHAR(100)
    DECLARE @Role AS VARCHAR(100)
    DECLARE @cmd VARCHAR(MAX)

    IF @Function = 0
    BEGIN
        SELECT
            шс.UIDСотрудника
           ,шс.Логин
           ,шс.ФИО
           ,шс.[Дата рождения]
           ,шс.Должность
           ,шс.СервернаяРоль
           ,шс.ДатаСоздания
           ,шс.ДатаИзменения
           ,шс.[ФИО Автор]
           ,шс.[ФИО Изменившего]
           ,шс.Телефон
           ,шс.Email
           ,шс.[Пол сотрудника]
        FROM dbo.vШтатСотрудники AS шс
        WHERE (@UIDСотрудника IS NULL
        OR шс.UIDСотрудника = @UIDСотрудника)
        AND шс.Логин != 'sa'
        ORDER BY шс.Логин
    END

    IF @Function = 1
    BEGIN
        SELECT
            шс.UIDСотрудника
           ,шс.Логин
           ,шс.Фамилия
           ,шс.Имя
           ,шс.Отчество
           ,шс.[Дата рождения]
           ,шс.IdДолжности
           ,шс.ДатаСоздания
           ,шс.ДатаИзменения
           ,шс.UIDАвтора
           ,шс.UIDИзменяющего
           ,шс.Телефон
           ,шс.Email
           ,шс.IdПола
        FROM dbo.ШтатСотрудники AS шс
        WHERE (@UIDСотрудника IS NULL
        OR шс.UIDСотрудника = @UIDСотрудника)
    END

    IF @Function = 2
    BEGIN
        SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
        BEGIN TRANSACTION

        SET @Role = (SELECT
                шд.СервернаяРоль
            FROM dbo.ШтатДолжности AS шд
            WHERE шд.IdДолжности = @IdДолжности)

        SET @cmd = 'CREATE LOGIN [' + @Домен + '\' + @Логин + ']
                    FROM WINDOWS
                    WITH
                    DEFAULT_DATABASE = master
                    
                    CREATE USER [' + @Логин + '] FOR LOGIN [' + @Домен + '\' + @Логин + '] WITH DEFAULT_SCHEMA=[dbo]
             
                    ALTER ROLE [' + @Role + '] ADD MEMBER [' + @Логин + ']'

        EXEC sys.sp_sqlexec @p1 = @cmd

        SET @UIDСотрудника = NEWID()
        INSERT dbo.ШтатСотрудники 
        (
            UIDСотрудника,
            Логин, Домен, 
            Фамилия,
            Имя,
            Отчество,
            [Дата рождения],
            IdДолжности,
            Телефон,
            Email,
            IdПола
        )
        VALUES 
        (
            @UIDСотрудника, 
            @Логин, 
            @Домен, 
            @Фамилия, 
            @Имя, 
            @Отчество, 
            @ДатаРождения, 
            @IdДолжности, 
            @Телефон, 
            @Email, 
            @IdПола
        )

        COMMIT TRANSACTION
    END

    IF @Function = 3
    BEGIN
        SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
        BEGIN TRANSACTION

        SET @RoleOld = (SELECT
                шд.СервернаяРоль
            FROM dbo.ШтатСотрудники AS шс
            INNER JOIN dbo.ШтатДолжности AS шд
                ON шс.IdДолжности = шд.IdДолжности
            WHERE шс.UIDСотрудника = @UIDСотрудника)

        SET @Role = (SELECT
                шд.СервернаяРоль
            FROM dbo.ШтатДолжности AS шд
            WHERE шд.IdДолжности = @IdДолжности)

        SET @cmd = 'ALTER ROLE [' + @Role + '] DROP MEMBER [' + @Логин + ']
                    ALTER ROLE [' + @Role + '] ADD MEMBER [' + @Логин + ']'

        EXEC sys.sp_sqlexec @p1 = @cmd

        UPDATE dbo.ШтатСотрудники
        SET Фамилия = @Фамилия
           ,Имя = @Имя
           ,Отчество = @Отчество
           ,[Дата рождения] = @ДатаРождения
           ,IdДолжности = @IdДолжности
           ,Телефон = @Телефон
           ,Email = @Email
           ,IdПола = @IdПола
           ,ДатаИзменения = dbo.DtТекущаяДатаВремя()
           ,UIDИзменяющего = dbo.ШтатПолучитьUIDСотрудника()
        WHERE UIDСотрудника = @UIDСотрудника

        COMMIT TRANSACTION
    END

    IF @Function = 4
    BEGIN
        SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
        BEGIN TRANSACTION

        SET @cmd = 'DROP LOGIN [' + @Логин + ']'
        EXEC sys.sp_sqlexec @p1 = @cmd
        DELETE FROM dbo.ШтатСотрудники
        WHERE UIDСотрудника = @UIDСотрудника

        COMMIT TRANSACTION
    END

    IF @Function IN (2, 3)
    BEGIN
        SELECT @UIDСотрудника AS id
    END

END
GO