CREATE TABLE [dbo].[Repayments]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CreditsId] INT NOT NULL, 
    [Principle] DECIMAL(19, 4) NOT NULL, 
    [Interest] DECIMAL(19, 4) NOT NULL, 
    [LastUpdated] DATETIME NOT NULL, 
    [TimeStamp] DATETIME NOT NULL, 
    CONSTRAINT [FK_Repayments_CreditsId] FOREIGN KEY ([CreditsId]) REFERENCES [dbo].[Credits]([Id]),
)
