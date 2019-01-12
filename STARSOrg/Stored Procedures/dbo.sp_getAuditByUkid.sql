CREATE PROCEDURE [dbo].sp_getAuditByUkid
	@ukid int
AS
	SELECT * FROM AUDIT
	WHERE ukid = @ukid
RETURN 0