CREATE PROCEDURE [dbo].sp_CheckSemesterIDExists
	@semesterID nvarchar(4),
	@recCount int = 0 OUTPUT
AS
	BEGIN
		SET @recCount = (SELECT count(0) FROM SEMESTER WHERE SemesterID=@semesterID)
		SELECT @recCount AS RecordCount
	END
RETURN 0