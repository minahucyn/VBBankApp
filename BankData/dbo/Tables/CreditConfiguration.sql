CREATE TABLE [dbo].[CreditConfiguration]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Description] VARCHAR(100) NOT NULL, 
    [Amount] DECIMAL(19, 4) NOT NULL, 
    [InterestPercentage] TINYINT NOT NULL
)
