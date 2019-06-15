CREATE PROCEDURE [dbo].[CanLogin](@username VARCHAR(50), @password VARCHAR(50))
AS
BEGIN
	DECLARE @result BIT
	IF((SELECT COUNT(*) FROM Users WHERE username=@username AND password=@password) = 1) SET @result = 1
	ELSE SET @result = 0

	RETURN(@result)
END 