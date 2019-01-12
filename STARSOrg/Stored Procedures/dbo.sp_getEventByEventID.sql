CREATE PROCEDURE [dbo].sp_getEventByEventID
	@eventID int 

AS
	SELECT * FROM EVENT
	WHERE EventID=@eventID
RETURN 0