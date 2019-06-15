CREATE TRIGGER PersonsTrigger
ON Persons
AFTER DELETE, UPDATE, INSERT
AS
	DECLARE @currDate DATETIME;
	SET @currDate = GETDATE();

	EXEC UpdateLastModifyTime @currDate