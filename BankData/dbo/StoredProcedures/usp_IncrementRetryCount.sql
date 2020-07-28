CREATE PROCEDURE [dbo].[usp_IncrementRetryCount]
	@Username varchar(100)
AS
BEGIN
	DECLARE @RetryCount TINYINT;
	DECLARE @RetryThreshold AS TINYINT
	--select retry count for user
    SELECT @RetryThreshold = [RetryCountThreshold]
	FROM [dbo].[UserDetails] 
	WHERE [Username] = @Username;
	
	--select retry threshold for user
    SELECT @RetryCount = [RetryCount] + 1
	FROM [dbo].[UserDetails] 
	WHERE [Username] = @Username;

	--update retry count
	UPDATE [dbo].[UserDetails]
	SET [RetryCount] = @RetryCount
	WHERE [Username] = @Username;

	--Check if account needs to be locked
	IF @RetryCount >= @RetryThreshold
	BEGIN
		--lock the account
		UPDATE [dbo].[UserDetails]
		SET [IsLockedOut] = 1
		WHERE [Username] = @Username
	END
END
