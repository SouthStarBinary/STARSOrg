CREATE PROCEDURE [dbo].sp_saveCourse
	@courseID nvarchar(10),
	@courseName nvarchar(50)
AS
	Declare @countExists int
	SELECT @countExists=count(0) FROM COURSE WHERE @courseID=CourseID
	IF (@countExists=0)
	BEGIN
		INSERT INTO [dbo].COURSE
		(
		CourseID,
		CourseName
		)
		VALUES
		(
		@courseID,
		@courseName
		)
		END
		ELSE
		BEGIN
			UPDATE [dbo].COURSE
			SET
			[CourseName]=@courseName
			WHERE CourseID=@courseID
			END
RETURN @@error