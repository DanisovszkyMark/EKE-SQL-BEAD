CREATE PROCEDURE [dbo].[DeletePerson](@id INT)
AS
BEGIN
	DELETE FROM Persons WHERE id = @id
END 