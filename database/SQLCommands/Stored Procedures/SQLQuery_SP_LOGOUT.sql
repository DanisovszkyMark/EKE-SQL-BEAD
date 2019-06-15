CREATE PROCEDURE [dbo].[Logout](@username VARCHAR(50))
AS
BEGIN
	UPDATE Users SET logged = 0 WHERE username=@username
END 
