CREATE PROCEDURE [dbo].[usp_UpdateUserHash]
	@Hash VARCHAR(135),
	@UserId int
AS
BEGIN
	UPDATE [dbo].[UserDetails]
	SET [PasswordHash] = @Hash
	WHERE [Id] = @UserId;
END
