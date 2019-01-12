create PROCEDURE [dbo].sp_getAllTutorsBySemesterID
@semesterID nvarchar (4)
AS
	SELECT PID FROM TUTOR_COURSE
	WHERE  @semesterID=SemesterID
RETURN 0