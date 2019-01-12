CREATE PROCEDURE [dbo].sp_CheckEventIDExists
	@eventID nvarchar(15)
	,@recCount int = 0 OUTPUT
AS
	BEGIN
	SET @recCount = (Select count(0) FROM EVENT WHERE EventID=@eventID) --count how many records there are where records event ID mtches th paramater being passed
	SELECT @recCount as RecordCount
	END

RETURN 0