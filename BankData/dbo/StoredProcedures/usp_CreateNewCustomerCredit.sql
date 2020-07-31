CREATE PROCEDURE [dbo].[usp_CreateNewCustomerCredit]
	@CreditConfigId INT,
	@Username VARCHAR(100)
AS
BEGIN
--setup explicit transacation 
	SET XACT_ABORT ON;
	BEGIN TRY
		BEGIN TRANSACTION;
		
		-- get user details id 
		DECLARE @UserDetailsId INT
		SELECT @UserDetailsId = [Id] FROM [dbo].[UserDetails] WHERE [Username]  = @Username;

		-- insert credit
		INSERT INTO	[dbo].[Credits]([CreditConfigId],[UserDetailsId],[LastUpdated],[TimeStamp])
		VALUES
		(@CreditConfigId,@UserDetailsId,GETDATE(),GETDATE());

		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
		THROW;
	END CATCH
END