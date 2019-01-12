CREATE PROCEDURE [dbo].sp_getMemberbyLastName
	@lastname nvarchar(75)
	
AS
	SELECT *
	FROM MEMBER
	WHERE LName LIKE @lastname + '%'
RETURN 0