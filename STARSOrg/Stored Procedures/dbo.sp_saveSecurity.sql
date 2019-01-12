CREATE PROCEDURE [dbo].sp_saveSecurity
	@PID nvarchar(7),
	@UserID nvarchar (15),
	@Password nvarchar (8),
	@SecRole nvarchar (10)
AS
	DECLARE @countExists int 
	SELECT @countExists  = count(0) FROM SECURITY WHERE @PID = PID
	IF (@countExists = 0) 
	BEGIN
		INSERT INTO [dbo].SECURITY
		( 
		PID, 
		UserID, 
		Password, 
		SecRole
		)
		values 
		( 
		@PID,
		@UserID,
		@Password,
		@SecRole
		)
	END
	ELSE 
		BEGIN
		 UPDATE [dbo].SECURITY
		 SET 
		 [UserID] = @UserID,
		 [Password] = @Password,
		 [SecRole] = @SecRole
		 WHERE PID = @PID
		END
RETURN 0