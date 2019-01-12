CREATE PROCEDURE [dbo].sp_saveEvent
	@eventID int
	,@eventDescription nvarchar(500)
	,@eventTypeID nvarchar(15)
	,@semesterID nvarchar(4)
	,@startDate Date 
	,@endDate Date 
	,@location nvarchar(50)
AS
	Declare @countExists int
	SELECT @countExists = count(0) FROM EVENT WHERE @eventID=EventID
	IF (@countExists=0)
	BEGIN
	INSERT INTO [dbo].EVENT
	(
	EventDescription
	,EventTypeID
	,SemesterID
	,StartDate
	,EndDate
	,Location

	)
	VALUES
	(
	@eventDescription
	,@eventTypeID
	,@semesterID
	,@startDate
	,@endDate
	,@location
	)

	END
	ELSE
	BEGIN
	-- if CountExists is NOT 0 then we already have the record so were updating it
	UPDATE [dbo].EVENT
	SET
	[EventDescription]=@eventDescription   --DONT HAVE TO BE IN BRACKETS BUT SAFER
	WHERE EventID=@eventID
	END
RETURN @@error