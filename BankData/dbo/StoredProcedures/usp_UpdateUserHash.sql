CREATE PROCEDURE [dbo].[usp_UpdateUserHash]
	@Hash VARCHAR(135),
	@Username VARCHAR(100)
AS
BEGIN
	UPDATE [dbo].[UserDetails]
	SET [PasswordHash] = @Hash
	WHERE [Username] = @Username;
END
