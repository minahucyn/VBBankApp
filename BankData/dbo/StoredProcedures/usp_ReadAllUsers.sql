CREATE PROCEDURE [dbo].[usp_ReadAllUsers]
AS
BEGIN
SET NOCOUNT ON;
	SELECT [u].[Id]
	,[u].[NidPp]
	,[ud].[Username]
	,[u].[Fullname]
	,[u].[PhoneNumber]
	,[r].[Description] AS [Role]
	,[u].[Birthdate]
	,[u].[Gender]
	,[ud].[IsActive]
	,[ud].[IsLockedOut]
	FROM [dbo].[Users] [u]
	INNER JOIN [dbo].[UserDetails] [ud] ON [ud].[UsersId] = [u].[Id]
	INNER JOIN [dbo].[Roles] [r] ON [r].[Id] = [ud].[RolesId];
END
