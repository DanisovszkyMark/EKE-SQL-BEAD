CREATE PROCEDURE [dbo].[DeletePersonCarConnection](@id INT)
AS
BEGIN
	DELETE FROM Cars WHERE person_id = @id
END 
