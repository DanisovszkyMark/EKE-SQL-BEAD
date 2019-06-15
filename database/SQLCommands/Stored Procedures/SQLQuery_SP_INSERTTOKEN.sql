CREATE PROCEDURE [dbo].[InsertToken](@token VARCHAR(50))
AS
BEGIN
	INSERT INTO Tokens(token)
	VALUES(@token)
END 


