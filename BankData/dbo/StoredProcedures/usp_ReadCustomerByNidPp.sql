CREATE PROCEDURE [dbo].[usp_ReadCustomerByNidPp]
	@NidPp VARCHAR(50)
AS
BEGIN
	SELECT [ud].[UsersId]
	, [u].[NidPp]
	, [u].[Fullname]
	, [u].[Gender]
	, [u].[Birthdate]
	, [u].[PhoneNumber]
	, [ud].[Username]
	FROM [dbo].[Users] [u]
	INNER JOIN [dbo].[UserDetails] [ud] ON [u].[Id] = [ud].[UsersId]
	WHERE [u].[NidPp] = @NidPp
END