CREATE PROCEDURE [dbo].[usp_CreateUser]
	@Fullname VARCHAR(100),
	@NidPp VARCHAR(50),
	@Birthdate DATE,
	@Gender BIT,
	@PhoneNumber VARCHAR(15),
	@RolesId INT,
	@Username VARCHAR(100)
AS
BEGIN
	--Default HASH
	DECLARE @Hash VARCHAR(135) = 'SHA512:88:g8WGo205+eNi4KdLk+Dawq1rmm6D5dmPWQ==:Ra+a+v9EjIGJXrgZ1wPwdqkWXEBpy0vvCtvgDwZOHxAYU/X0VYORXj7GIm4h5Sw3d+HLuUR1BEQTK/ifMafOFg==';
	DECLARE @TableInsertedData TABLE ([UserId] INT);
	DECLARE @InsertedUserId INT = -1;

	-- insert into dbo.Users
	INSERT INTO [dbo].[Users] ([Fullname],[NidPp],[Birthdate],[Gender],[PhoneNumber])
	OUTPUT Inserted.Id INTO @TableInsertedData
	VALUES (@Fullname,@NidPp,@Birthdate,@Gender,@PhoneNumber)

	-- Get the inserted Id into @InsertedUserId
	SELECT @InsertedUserId = [UserId] FROM @TableInsertedData;

	-- insert into dbo.UserDetails
	INSERT INTO [dbo].[UserDetails] ([UsersId],[RolesId],[Username],[PasswordHash])
	VALUES (@InsertedUserId,@RolesId,@Username,@Hash)
END

