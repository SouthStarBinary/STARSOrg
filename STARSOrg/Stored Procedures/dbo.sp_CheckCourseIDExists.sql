CREATE PROCEDURE [dbo].sp_CheckCourseIDExists
	@courseID nvarchar(10),
	@recCount int = 0 OUTPUT
AS
	BEGIN
		SET @recCount = (SELECT count(0) FROM COURSE WHERE CourseID=@courseID)
		SELECT @recCount AS RecordCount
	END
RETURN 0