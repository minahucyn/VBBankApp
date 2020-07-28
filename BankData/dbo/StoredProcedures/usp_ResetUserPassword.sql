CREATE PROCEDURE [dbo].[usp_ResetUserPassword]
	@Username VARCHAR(100)
AS
BEGIN
	UPDATE [dbo].[UserDetails]
	SET [PasswordHash] = 'SHA512:88:g8WGo205+eNi4KdLk+Dawq1rmm6D5dmPWQ==:Ra+a+v9EjIGJXrgZ1wPwdqkWXEBpy0vvCtvgDwZOHxAYU/X0VYORXj7GIm4h5Sw3d+HLuUR1BEQTK/ifMafOFg=='
	WHERE [Username] = @Username;
END
