CREATE TABLE [dbo].[UserDetails]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UsersId] INT NOT NULL , 
    [RolesId] INT NOT NULL , 
    [Username] VARCHAR(100) NOT NULL UNIQUE,
	[RetryCount] INT NOT NULL DEFAULT 0,
	[RetryCountThreshold] INT NOT NULL DEFAULT 3,
	[IsLockedOut] BIT NOT NULL DEFAULT 0,
	[IsActive] BIT NOT NULL DEFAULT 1,
	[PasswordHash] VARCHAR(100) NOT NULL, 
    CONSTRAINT [FK_UserDetails_Users] FOREIGN KEY ([UsersId]) REFERENCES [dbo].[Users]([Id]), 
    CONSTRAINT [FK_UserDetails_Roles] FOREIGN KEY ([RolesId]) REFERENCES [dbo].[Roles]([Id])


)
