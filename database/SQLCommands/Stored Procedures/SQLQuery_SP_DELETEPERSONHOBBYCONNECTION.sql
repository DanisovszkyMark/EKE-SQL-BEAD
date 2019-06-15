CREATE PROCEDURE [dbo].[DeletePersonHobbyConnection](@id INT)
AS
BEGIN
	DELETE FROM Person_Hobby WHERE person_id = @id
END 
