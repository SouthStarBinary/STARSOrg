CREATE PROCEDURE [dbo].sp_getAllTutorsCoursesByTutorID
@courseID nvarchar(10)
,@semesterID nvarchar (4)
AS
	SELECT PID FROM TUTOR_COURSE
	WHERE @courseID=CourseID AND @semesterID=SemesterID
RETURN 0