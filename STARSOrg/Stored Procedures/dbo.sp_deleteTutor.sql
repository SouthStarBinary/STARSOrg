CREATE PROCEDURE [dbo].sp_deleteTutor
	@ukid int
	,@pid nvarchar(7)
	,@courseID nvarchar(10)
	,@semesterID nvarchar(4)
AS
	DELETE FROM TUTOR_COURSE
	WHERE @pid=PID AND @courseID=CourseID AND @semesterID=SemesterID

RETURN 0