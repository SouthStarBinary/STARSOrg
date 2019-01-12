CREATE PROCEDURE [dbo].sp_getRoleByRoleID
	@roleID nvarchar(15)
AS
	SELECT * FROM ROLE
	WHERE RoleID = @roleID
RETURN 0