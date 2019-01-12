CREATE PROCEDURE [dbo].sp_CheckukidExists
	@ukid int
	,@recCount int = 0 OUTPUT
AS
	BEGIN
		SET @recCount = (SELECT count(0) FROM TUTOR_COURSE WHERE ukid=@ukid)
		SELECT @recCount as RecordCount
	END
RETURN 0