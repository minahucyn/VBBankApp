CREATE PROCEDURE [dbo].[usp_ReadCustomerSecurities]
	@UserDetailsId INT
AS
BEGIN
	SELECT [s].[Id]
	, [s].[Description]
	, [s].[Worth]
	, [c].[Id] as [CreditId]
	FROM [dbo].[Credits] [c]
	INNER JOIN [dbo].[Securities] [s] ON [s].[CreditsId] = [c].[Id]
	WHERE [c].[UserDetailsId] = @UserDetailsId
END
