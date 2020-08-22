IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200816091031_initialize')
BEGIN
    CREATE TABLE [Driver] (
        [DriverId] int NOT NULL IDENTITY,
        [FirsLastMidName] nvarchar(30) NOT NULL,
        [Category] int NOT NULL,
        [RightsNumber] nvarchar(15) NOT NULL,
        CONSTRAINT [PK_Driver] PRIMARY KEY ([DriverId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200816091031_initialize')
BEGIN
    CREATE TABLE [NormaFuel] (
        [NormaFuelId] int NOT NULL IDENTITY,
        [Linear] int NOT NULL,
        [Summer] int NOT NULL,
        [Winter] int NOT NULL,
        CONSTRAINT [PK_NormaFuel] PRIMARY KEY ([NormaFuelId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200816091031_initialize')
BEGIN
    CREATE TABLE [Tire] (
        [TireId] int NOT NULL IDENTITY,
        [Name] nvarchar(20) NOT NULL,
        [Brand] nvarchar(20) NOT NULL,
        [Date] datetime2 NOT NULL,
        [RunStart] int NOT NULL,
        CONSTRAINT [PK_Tire] PRIMARY KEY ([TireId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200816091031_initialize')
BEGIN
    CREATE TABLE [TypeAuto] (
        [TypeAutoId] int NOT NULL IDENTITY,
        [NameType] nvarchar(50) NOT NULL,
        CONSTRAINT [PK_TypeAuto] PRIMARY KEY ([TypeAutoId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200816091031_initialize')
BEGIN
    CREATE TABLE [TypeFuel] (
        [TypeFuelId] int NOT NULL IDENTITY,
        [Fuel] nvarchar(20) NOT NULL,
        [Cost] float NOT NULL,
        [ToDate] datetime2 NOT NULL,
        CONSTRAINT [PK_TypeFuel] PRIMARY KEY ([TypeFuelId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200816091031_initialize')
BEGIN
    CREATE TABLE [WinterTime] (
        [WinterTimeId] int NOT NULL IDENTITY,
        [WinterNorma] int NOT NULL,
        [DateStart] datetime2 NOT NULL,
        [DateEnd] datetime2 NOT NULL,
        [Temperature] float NOT NULL,
        CONSTRAINT [PK_WinterTime] PRIMARY KEY ([WinterTimeId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200816091031_initialize')
BEGIN
    CREATE TABLE [Trailer] (
        [TrailerId] int NOT NULL IDENTITY,
        [Number] nvarchar(20) NOT NULL,
        [Massa] int NOT NULL,
        [TireId] int NOT NULL,
        CONSTRAINT [PK_Trailer] PRIMARY KEY ([TrailerId]),
        CONSTRAINT [FK_Trailer_Tire_TireId] FOREIGN KEY ([TireId]) REFERENCES [Tire] ([TireId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200816091031_initialize')
BEGIN
    CREATE TABLE [Device] (
        [DeviceId] int NOT NULL IDENTITY,
        [Namedevice] nvarchar(30) NOT NULL,
        [TypeFuelId] int NOT NULL,
        [SumerTime] datetime2 NOT NULL,
        [WinterTimeId] int NOT NULL,
        [Harmfulness] bit NOT NULL,
        [TireId] int NOT NULL,
        CONSTRAINT [PK_Device] PRIMARY KEY ([DeviceId]),
        CONSTRAINT [FK_Device_Tire_TireId] FOREIGN KEY ([TireId]) REFERENCES [Tire] ([TireId]),
        CONSTRAINT [FK_Device_TypeFuel_TypeFuelId] FOREIGN KEY ([TypeFuelId]) REFERENCES [TypeFuel] ([TypeFuelId]) ON DELETE CASCADE,
        CONSTRAINT [FK_Device_WinterTime_WinterTimeId] FOREIGN KEY ([WinterTimeId]) REFERENCES [WinterTime] ([WinterTimeId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200816091031_initialize')
BEGIN
    CREATE TABLE [AutoCar] (
        [AutoCarId] int NOT NULL IDENTITY,
        [NameAuto] nvarchar(30) NOT NULL,
        [Number] nvarchar(12) NOT NULL,
        [Mileage] int NOT NULL,
        [TypeFuelId] int NOT NULL,
        [NormaFuelId] int NOT NULL,
        [TrailerId] int NOT NULL,
        [DriverId] int NOT NULL,
        [TypeAutoId] int NOT NULL,
        [TireId] int NOT NULL,
        [Harmfulness] int NOT NULL,
        [Navigation] bit NOT NULL,
        [Injector] bit NOT NULL,
        CONSTRAINT [PK_AutoCar] PRIMARY KEY ([AutoCarId]),
        CONSTRAINT [FK_AutoCar_Driver_DriverId] FOREIGN KEY ([DriverId]) REFERENCES [Driver] ([DriverId]) ON DELETE CASCADE,
        CONSTRAINT [FK_AutoCar_NormaFuel_NormaFuelId] FOREIGN KEY ([NormaFuelId]) REFERENCES [NormaFuel] ([NormaFuelId]) ON DELETE CASCADE,
        CONSTRAINT [FK_AutoCar_Tire_TireId] FOREIGN KEY ([TireId]) REFERENCES [Tire] ([TireId]),
        CONSTRAINT [FK_AutoCar_Trailer_TrailerId] FOREIGN KEY ([TrailerId]) REFERENCES [Trailer] ([TrailerId]) ON DELETE CASCADE,
        CONSTRAINT [FK_AutoCar_TypeAuto_TypeAutoId] FOREIGN KEY ([TypeAutoId]) REFERENCES [TypeAuto] ([TypeAutoId]) ON DELETE CASCADE,
        CONSTRAINT [FK_AutoCar_TypeFuel_TypeFuelId] FOREIGN KEY ([TypeFuelId]) REFERENCES [TypeFuel] ([TypeFuelId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200816091031_initialize')
BEGIN
    CREATE TABLE [Balance] (
        [BalanceId] int NOT NULL IDENTITY,
        [Date] datetime2 NOT NULL,
        [AutoCarId] int NOT NULL,
        [Leftovers] int NOT NULL,
        [Sug] int NOT NULL,
        CONSTRAINT [PK_Balance] PRIMARY KEY ([BalanceId]),
        CONSTRAINT [FK_Balance_AutoCar_AutoCarId] FOREIGN KEY ([AutoCarId]) REFERENCES [AutoCar] ([AutoCarId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200816091031_initialize')
BEGIN
    CREATE TABLE [Maintenance] (
        [MaintenanceId] int NOT NULL IDENTITY,
        [TypeTO] nvarchar(10) NOT NULL,
        [AutoCarId] int NOT NULL,
        [DateTO] datetime2 NOT NULL,
        CONSTRAINT [PK_Maintenance] PRIMARY KEY ([MaintenanceId]),
        CONSTRAINT [FK_Maintenance_AutoCar_AutoCarId] FOREIGN KEY ([AutoCarId]) REFERENCES [AutoCar] ([AutoCarId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200816091031_initialize')
BEGIN
    CREATE INDEX [IX_AutoCar_DriverId] ON [AutoCar] ([DriverId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200816091031_initialize')
BEGIN
    CREATE INDEX [IX_AutoCar_NormaFuelId] ON [AutoCar] ([NormaFuelId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200816091031_initialize')
BEGIN
    CREATE INDEX [IX_AutoCar_TireId] ON [AutoCar] ([TireId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200816091031_initialize')
BEGIN
    CREATE INDEX [IX_AutoCar_TrailerId] ON [AutoCar] ([TrailerId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200816091031_initialize')
BEGIN
    CREATE INDEX [IX_AutoCar_TypeAutoId] ON [AutoCar] ([TypeAutoId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200816091031_initialize')
BEGIN
    CREATE INDEX [IX_AutoCar_TypeFuelId] ON [AutoCar] ([TypeFuelId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200816091031_initialize')
BEGIN
    CREATE INDEX [IX_Balance_AutoCarId] ON [Balance] ([AutoCarId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200816091031_initialize')
BEGIN
    CREATE INDEX [IX_Device_TireId] ON [Device] ([TireId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200816091031_initialize')
BEGIN
    CREATE INDEX [IX_Device_TypeFuelId] ON [Device] ([TypeFuelId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200816091031_initialize')
BEGIN
    CREATE INDEX [IX_Device_WinterTimeId] ON [Device] ([WinterTimeId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200816091031_initialize')
BEGIN
    CREATE INDEX [IX_Maintenance_AutoCarId] ON [Maintenance] ([AutoCarId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200816091031_initialize')
BEGIN
    CREATE INDEX [IX_Trailer_TireId] ON [Trailer] ([TireId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200816091031_initialize')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200816091031_initialize', N'3.1.6');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200819181945_normafueldouble')
BEGIN
    ALTER TABLE [AutoCar] DROP CONSTRAINT [FK_AutoCar_Tire_TireId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200819181945_normafueldouble')
BEGIN
    ALTER TABLE [Device] DROP CONSTRAINT [FK_Device_Tire_TireId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200819181945_normafueldouble')
BEGIN
    ALTER TABLE [Trailer] DROP CONSTRAINT [FK_Trailer_Tire_TireId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200819181945_normafueldouble')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[NormaFuel]') AND [c].[name] = N'Winter');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [NormaFuel] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [NormaFuel] ALTER COLUMN [Winter] float NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200819181945_normafueldouble')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[NormaFuel]') AND [c].[name] = N'Summer');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [NormaFuel] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [NormaFuel] ALTER COLUMN [Summer] float NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200819181945_normafueldouble')
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[NormaFuel]') AND [c].[name] = N'Linear');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [NormaFuel] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [NormaFuel] ALTER COLUMN [Linear] float NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200819181945_normafueldouble')
BEGIN
    ALTER TABLE [AutoCar] ADD CONSTRAINT [FK_AutoCar_Tire_TireId] FOREIGN KEY ([TireId]) REFERENCES [Tire] ([TireId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200819181945_normafueldouble')
BEGIN
    ALTER TABLE [Device] ADD CONSTRAINT [FK_Device_Tire_TireId] FOREIGN KEY ([TireId]) REFERENCES [Tire] ([TireId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200819181945_normafueldouble')
BEGIN
    ALTER TABLE [Trailer] ADD CONSTRAINT [FK_Trailer_Tire_TireId] FOREIGN KEY ([TireId]) REFERENCES [Tire] ([TireId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200819181945_normafueldouble')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200819181945_normafueldouble', N'3.1.6');
END;

GO

