CREATE PROCEDURE [dbo].sp_saveRole
	@roleID nvarchar(15),
	@roleDescription nvarchar(100)
AS
	Declare @countExists int 
	SELECT @countExists = count(0) FROM ROLE WHERE @roleID = RoleID
	IF (@countExists = 0) 
	BEGIN
		INSERT INTO [dbo].ROLE
			(RoleID, 
			RoleDescription
			) 
		VALUES
			(
			@roleID, 
			@roleDescription
			) 
		END
		ELSE 
		BEGIN
		 UPDATE [dbo].ROLE
		 SET
	      [RoleDescription] = @roleDescription 
		 WHERE RoleID = @roleID
		END
RETURN @@error