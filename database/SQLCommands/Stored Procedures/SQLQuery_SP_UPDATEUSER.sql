CREATE PROCEDURE [dbo].[UpdateUser](@username VARCHAR(50), @password VARCHAR(50), @newUsername VARCHAR(50), @newPassword VARCHAR(50))
AS
BEGIN
	UPDATE Users SET username = @newUsername, password = @newPassword
	WHERE username = @username AND password = @password
END 
