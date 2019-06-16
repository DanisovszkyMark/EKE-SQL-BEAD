CREATE PROCEDURE InsertPersonParent(@person_id INT, @parent_id INT)
AS
BEGIN
	INSERT INTO Person_Parent(person_id, parent_id)
	VALUES(@person_id, @parent_id)
END