CREATE PROCEDURE [dbo].sp_saveAudit
	@ukid int,
	@PID nvarchar(7),
	@ACCESSTIMESTAMP date,
	@SUCCESS bit
AS
	Declare @countExists int 
	SELECT @countExists = count(0) FROM AUDIT WHERE @PID = PID
	BEGIN
		INSERT INTO [dbo].AUDIT
			(PID, 
			ACCESSTIMESTAMP,
			SUCCESS
			) 
		VALUES
			(
			@PID, 
			@ACCESSTIMESTAMP,
			@SUCCESS
			) 
	END
RETURN @@error