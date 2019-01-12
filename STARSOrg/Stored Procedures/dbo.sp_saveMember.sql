CREATE PROCEDURE [dbo].sp_saveMember
@pID nvarchar(7)
,@fName nvarchar(50)
,@lName nvarchar(75)
,@mi nvarchar(1)
,@email nvarchar(50)
,@phone nvarchar(13)
,@photoPath nvarchar(300)
AS
Declare @countExists int
SELECT @countExists=count(0) FROM MEMBER WHERE @pID=PID
IF (@countExists=0)
BEGIN
INSERT INTO [dbo].MEMBER

	(
	PID
	,FName
	,LName
	,MI
	,Email
	,Phone
	,PhotoPath
	)
	VALUES
	(
	@pID
	,@fName
	,@lName
	,@mi
	,@email
	,@phone
	,@photoPath
	)
	END
	ELSE
	BEGIN
UPDATE [dbo].MEMBER
SET
[FName]=@fName,
[LName]=@lName,
[MI]=@mi,
[Email]=@email,
[Phone]=@phone,
[PhotoPath]=@photoPath
WHERE PID=@pID
END
RETURN @@error