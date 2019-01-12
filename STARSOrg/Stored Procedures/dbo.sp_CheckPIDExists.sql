CREATE PROCEDURE [dbo].sp_CheckPIDExists
	@PID nvarchar(15),
	@recCount int = 0 OUTPUT
AS
	Begin 
		Set @recCount = (select count(0) FROM SECURITY WHERE PID=@PID)
		Select @recCount as RecordCount
	END 

RETURN 0