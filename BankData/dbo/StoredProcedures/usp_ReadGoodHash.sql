CREATE PROCEDURE [dbo].[usp_ReadGoodHash]
	@Username VARCHAR(100)
AS
BEGIN
	SELECT [Username], [PasswordHash] AS [GoodHash] 
	FROM [dbo].[UserDetails] 
	WHERE [Username] = @Username;
END
