CREATE PROCEDURE [dbo].[usp_ReadAllCreditConfig]
AS
BEGIN
	--read all credit configuration
	SELECT [Id]
	,[Description]
	,[Amount] AS PrincipleAmount
	,CAST([InterestPercentage] AS DECIMAL) AS InterestAmount
	FROM [dbo].[CreditConfiguration];
END
