CREATE PROCEDURE [dbo].[usp_ReadCustomerCredits]
	@UserId INT
AS
BEGIN
	SELECT [c].[Id]
	, [cc].[Description]
	, [cc].[Amount] AS  [PrincipleAmount]
	, (([cc].[InterestPercentage] / CAST(100 AS DECIMAL(19,4)))*[cc].[Amount]) AS [InterestAmount]
	, [c].[LastUpdated]
	, [c].[TimeStamp]
	FROM [dbo].[Credits] [c]
	INNER JOIN [dbo].[CreditConfiguration] [cc] 
						ON [c].[CreditConfigId] = [cc].[Id]
	WHERE [UserDetailsId] = @UserId
END