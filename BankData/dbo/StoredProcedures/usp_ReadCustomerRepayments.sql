CREATE PROCEDURE [dbo].[usp_ReadCustomerRepayments]
	@UserDetailsId INT
AS
BEGIN
	SELECT [r].[Id]
	, [r].[CreditsId]
	, [r].[Principle]
	, [r].[Interest]
	, [r].[LastUpdated]
	, [r].[TimeStamp]
	FROM [dbo].[Credits] [c]
	INNER JOIN [dbo].[Repayments] [r] ON [c].[Id] = [r].[CreditsId]
	WHERE [c].[UserDetailsId] = @UserDetailsId;
END