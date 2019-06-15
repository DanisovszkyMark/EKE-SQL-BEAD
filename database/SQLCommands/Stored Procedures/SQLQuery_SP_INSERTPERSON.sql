CREATE PROCEDURE [dbo].[InsertPerson](@name VARCHAR(250), @birth_day DATE, @job_id INT, @salary INT)
AS
BEGIN
	INSERT INTO Persons(name, birth_day, job_id, salary)
    VALUES (@name, @birth_day, @job_id, @salary)
END 
