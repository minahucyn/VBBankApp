CREATE PROCEDURE [dbo].[usp_ReadAuthDetails]
	@Username VARCHAR(100)
AS
BEGIN
	SET NOCOUNT ON;
	--variables
	DECLARE @RoleClaimsCSV varchar(500)
	DECLARE @RolesId int

	--get rolesId
	SELECT @RolesId = [RolesId] FROM [dbo].[UserDetails] WHERE [Username] = @Username;
	--Get claims
	SELECT @RoleClaimsCSV = STRING_AGG([c].[Description],',')
	FROM [dbo].[RoleClaims] [rc]
	INNER JOIN [dbo].[Claims] [c] ON [rc].[ClaimsId] = [c].[Id]
	WHERE [rc].[RolesId] = @RolesId;

	--Select all data
	SELECT [u].[Fullname]
	,[ud].[Username]
	,[r].[Description] AS [UserRole]
	,[ud].[PasswordHash] AS [GoodHash]
	,[ud].[IsLockedOut] AS [IsLocked]
	,[ud].[IsActive]
	,[rsm].[MenuJson]
	,@RoleClaimsCSV AS [RoleClaimsCSV]
	FROM [dbo].[Users] [u]
	INNER JOIN [dbo].[UserDetails] [ud] ON [u].[Id] = [ud].[UsersId]
	INNER JOIN [dbo].[Roles] [r] ON [r].[Id] = [ud].[RolesId]
	INNER JOIN [dbo].[RoleSpecificMenus] [rsm] ON [rsm].[RolesId] = [r].[Id]
	WHERE [ud].[Username] = @Username;
END
