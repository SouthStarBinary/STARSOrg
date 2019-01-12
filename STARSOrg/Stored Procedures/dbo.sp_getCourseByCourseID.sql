CREATE PROCEDURE [dbo].sp_getCourseByCourseID
	@courseID nvarchar(10)
AS
	SELECT * FROM COURSE
	WHERE CourseID=@courseID
RETURN 0