CREATE PROCEDURE [dbo].sp_CheckRoleIDExists
	@roleID nvarchar(15), 
	@recCount int = 0 OUTPUT
AS
	BEGIN 
		SET @recCount = (select count(0) FROM ROLE WHERE RoleID=@roleID)
		SELECT @recCount as RecordCount 
	END 

RETURN 0