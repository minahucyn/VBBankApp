CREATE TABLE [dbo].[RoleClaims]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [RolesId] INT NOT NULL, 
    [ClaimsId] INT NOT NULL, 
    CONSTRAINT [FK_RoleClaims_Roles] FOREIGN KEY ([RolesId]) REFERENCES [dbo].[Roles]([Id]), 
    CONSTRAINT [FK_RoleClaims_Claims] FOREIGN KEY ([ClaimsId]) REFERENCES [dbo].[Claims]([Id]), 

)
