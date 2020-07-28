CREATE TABLE [dbo].[Securities]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
    [CreditsId] INT NOT NULL, 
    [Description] VARCHAR(100) NOT NULL, 
    [Worth] DECIMAL(19, 4) NOT NULL, 
    CONSTRAINT [FK_Securities_CustomerCreditsId] FOREIGN KEY ([CreditsId]) REFERENCES [dbo].[Credits]([Id])
)
