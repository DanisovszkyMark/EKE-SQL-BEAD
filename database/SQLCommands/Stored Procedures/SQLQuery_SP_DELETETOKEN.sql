CREATE PROCEDURE [dbo].[DeleteToken](@token VARCHAR(50))
AS
BEGIN
	DELETE FROM Tokens WHERE token=@token
END 


