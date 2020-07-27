CREATE TABLE [dbo].[RoleSpecificMenus]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[MenuJson] VARCHAR(500) NOT NULL,
	[RolesId] INT NOT NULL, 
    CONSTRAINT [FK_RoleSpecificMenus_Roles] FOREIGN KEY ([RolesId]) REFERENCES [dbo].[Roles]([Id]),

)
