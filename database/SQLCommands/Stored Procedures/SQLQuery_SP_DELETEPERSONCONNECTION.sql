CREATE PROCEDURE [dbo].[DeletePersonConnection](@id INT)
AS
BEGIN
	EXEC DeletePersonCarConnection @id
	EXEC DeletePersonHobbyConnection @id
	EXEC DeletePersonParentConnection @id
	EXEC DeletePersonPetConnection @id
END 
