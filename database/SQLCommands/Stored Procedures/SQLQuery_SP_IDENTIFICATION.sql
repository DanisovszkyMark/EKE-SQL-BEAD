CREATE PROCEDURE [dbo].[Identification](@token VARCHAR(50))
AS
BEGIN
	DECLARE @result BIT
	IF((SELECT COUNT(*) FROM Tokens WHERE token=@token) =1) SET @result = 1
	ELSE SET @result = 0

	RETURN(@result)
END 
