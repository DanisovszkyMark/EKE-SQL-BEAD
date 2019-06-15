CREATE PROCEDURE [dbo].[DeletePersonParentConnection](@id INT)
AS
BEGIN
	DELETE FROM Person_Parent WHERE person_id = @id
END 
