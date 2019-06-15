CREATE PROCEDURE [dbo].[Login](@username VARCHAR(50))
AS
BEGIN
	UPDATE Users SET logged = 1 WHERE username=@username
END 
