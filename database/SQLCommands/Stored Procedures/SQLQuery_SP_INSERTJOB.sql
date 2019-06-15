CREATE PROCEDURE [dbo].[InsertJob](@workplace_name VARCHAR(250), @job VARCHAR(120), @description VARCHAR(250))
AS
BEGIN
	INSERT INTO Jobs(workplace_name, job, description)
	VALUES(@workplace_name, @job, @description)
END 

