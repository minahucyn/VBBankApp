CREATE TABLE [dbo].[Credits]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
    [CreditConfigId] INT NOT NULL, 
    [UserDetailsId] INT NOT NULL, 
    [LastUpdated] DATETIME NOT NULL, 
    [TimeStamp] DATETIME NOT NULL, 
    CONSTRAINT [FK_Credits_CreditConfigId] FOREIGN KEY ([CreditConfigId]) REFERENCES [dbo].[CreditConfiguration]([Id]), 
    CONSTRAINT [FK_Credits_UserDetailsId] FOREIGN KEY ([UserDetailsId]) REFERENCES [dbo].[UserDetails]([Id])
)
