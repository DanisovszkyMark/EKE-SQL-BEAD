CREATE PROCEDURE [dbo].[UpdateLastModifyTime](@last_modify_time datetime)
AS
BEGIN
	UPDATE Refresh SET last_modify_time = @last_modify_time WHERE id=1
END 


