CREATE PROCEDURE [dbo].[usp_ResetRetryCount]
	@Username VARCHAR(100)
AS
BEGIN
	UPDATE [dbo].[UserDetails]
	SET [RetryCount] = 0
	WHERE [Username] = @Username;
END
