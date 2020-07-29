CREATE PROCEDURE [dbo].[usp_ReadAllCustomerSearchDatasourceFields]

AS
BEGIN
	SELECT [NidPp], [Fullname]
	FROM [dbo].[Users]
END
