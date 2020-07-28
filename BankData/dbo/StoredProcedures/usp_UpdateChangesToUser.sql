CREATE PROCEDURE [dbo].[usp_UpdateChangesToUser]
	@UserId INT,
	@NidPp VARCHAR(50),
	@Fullname VARCHAR(100),
	@Username VARCHAR(100),
	@PhoneNumber VARCHAR(15),
	@RoleId INT,
	@Birthdate DATE,
	@Gender BIT,
	@IsActive BIT
AS
BEGIN
	--update dbo.Users
	UPDATE [dbo].[Users]
	SET [Fullname] = @Fullname,
		[NidPp] = @NidPp,
		[PhoneNumber] = @PhoneNumber,
		[Birthdate] = @Birthdate,
		[Gender] = @Gender
	WHERE [Id]  = @UserId;

	--update dbo.UserDetails
	UPDATE [dbo].[UserDetails]
	SET [RolesId] = @RoleId,
		[IsActive] = @IsActive,
		[Username] = @Username
	WHERE [UsersId] = @UserId;
		
END
