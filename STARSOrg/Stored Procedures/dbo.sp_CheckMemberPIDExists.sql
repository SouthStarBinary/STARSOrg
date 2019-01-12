CREATE PROCEDURE [dbo].sp_CheckMemberPIDExists
@pID nvarchar(7)
,@recCount int = 0 OUTPUT
AS
BEGIN
SET @recCount = (SELECT count(0) FROM MEMBER WHERE PID=@pID)
SELECT @recCount as RecordCount
END
RETURN 0