IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181202033934_initial')
BEGIN
    CREATE TABLE [Customers] (
        [CustomerID] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        [City] nvarchar(max) NULL,
        [ZipCode] nvarchar(max) NULL,
        [CanContact] bit NOT NULL,
        [Terms] bit NOT NULL,
        CONSTRAINT [PK_Customers] PRIMARY KEY ([CustomerID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181202033934_initial')
BEGIN
    CREATE TABLE [Messages] (
        [CustomerID] int NULL,
        [MessageText] nvarchar(max) NULL,
        [Reason] nvarchar(max) NULL,
        [bugOrError] bit NOT NULL,
        [MessageID] int NOT NULL IDENTITY,
        [TimeSent] datetime2 NOT NULL,
        CONSTRAINT [PK_Messages] PRIMARY KEY ([MessageID]),
        CONSTRAINT [FK_Messages_Customers_CustomerID] FOREIGN KEY ([CustomerID]) REFERENCES [Customers] ([CustomerID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181202033934_initial')
BEGIN
    CREATE INDEX [IX_Messages_CustomerID] ON [Messages] ([CustomerID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181202033934_initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20181202033934_initial', N'2.1.4-rtm-31024');
END;

GO

