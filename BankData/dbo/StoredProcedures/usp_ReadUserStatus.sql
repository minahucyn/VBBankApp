CREATE PROCEDURE [dbo].[usp_ReadUserStatus]
	@Username VARCHAR(100)
AS
BEGIN
	SELECT [IsActive],[IsLockedOut]
	FROM [dbo].[UserDetails]
	WHERE [Username] = @Username;
END
