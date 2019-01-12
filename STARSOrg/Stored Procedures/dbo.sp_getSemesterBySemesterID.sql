CREATE PROCEDURE [dbo].sp_getSemesterBySemesterID
	@semesterID nvarchar(4)
AS
	SELECT * FROM SEMESTER
	WHERE SemesterID=@semesterID
RETURN 0