CREATE PROCEDURE [dbo].[DeletePersonPetConnection](@id INT)
AS
BEGIN
	DELETE FROM Person_Pet WHERE person_id = @id
END 

