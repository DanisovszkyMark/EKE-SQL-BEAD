ALTER PROCEDURE [dbo].[UpdatePerson](@id INT, @name VARCHAR(250), @birth_day DATE, @job_id INT, @salary INT)
AS
BEGIN
	UPDATE Persons SET	name = @name,
						birth_day = @birth_day,
                        job_id = @job_id,
						salary = @salary
                        WHERE id = @id
END 
