CREATE PROCEDURE [dbo].sp_saveTutor
	@ukid int
	,@pid nvarchar(7)
	,@courseID nvarchar(10)
	,@semesterID nvarchar(4)
AS
	Declare @countExists int
	SELECT @countExists=count(0) FROM TUTOR_COURSE WHERE @ukid=ukid
	IF (@countExists=0) 
	BEGIN
		INSERT INTO [dbo].TUTOR_COURSE
			(
			PID
			,CourseID
			,SemesterID
			)
		VALUES
			(
			@pid
			,@courseID
			,@semesterID
			)
	END
	ELSE
	BEGIN
		UPDATE [dbo].TUTOR_COURSE
		SET
			[PID]=@pid
		WHERE ukid=@ukid	
	END	
RETURN @@error