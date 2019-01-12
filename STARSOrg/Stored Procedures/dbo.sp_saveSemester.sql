CREATE PROCEDURE [dbo].sp_saveSemester
	@semesterID nvarchar(4),
	@semesterDescription nvarchar(100)
AS
	Declare @countExists int
	SELECT @countExists=count(0) FROM SEMESTER WHERE @semesterID=SemesterID
	IF (@countExists=0)
	BEGIN
		INSERT INTO [dbo].SEMESTER
		(
		SemesterID,
		SemesterDescription
		)
		VALUES
		(
		@semesterID,
		@semesterDescription
		)
		END
		ELSE
		BEGIN
			UPDATE [dbo].SEMESTER
			SET
			[SemesterDescription]=@semesterDescription
			WHERE SemesterID=@semesterID
			END
RETURN @@error