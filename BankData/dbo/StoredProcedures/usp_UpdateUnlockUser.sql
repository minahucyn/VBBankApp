CREATE PROCEDURE [dbo].[usp_UpdateUnlockUser]
	@Username VARCHAR(100)
AS
BEGIN
	UPDATE [dbo].[UserDetails]
	SET [IsLockedOut] = 0
	WHERE [Username] = @Username;
END
