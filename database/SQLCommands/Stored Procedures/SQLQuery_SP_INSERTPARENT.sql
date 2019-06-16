CREATE PROCEDURE InsertParent(@name VARCHAR(250), @birth_day DATE)
AS
BEGIN
	INSERT INTO Parents(name, birth_day)
	VALUES(@name, @birth_day)
END