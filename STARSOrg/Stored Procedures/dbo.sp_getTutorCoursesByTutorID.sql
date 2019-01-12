CREATE PROCEDURE [dbo].sp_getTutorCoursesByTutorID
@PID nvarchar(7),@semesterID nvarchar (4)
AS
	SELECT * FROM TUTOR_COURSE
	WHERE @PID=PID AND @semesterID=SemesterID
RETURN 0