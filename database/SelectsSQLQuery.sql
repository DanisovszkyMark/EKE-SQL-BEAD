-- Lekérdezések --
Select * from Parents;
select * from Jobs;
Select * from Persons;
Select * from Persons where job_id = (
SELECT id from Jobs WHERE job = 'Demonstrátor');
SELECT * FROM Hobbies;
SELECT * FROM Hobbies LEFT JOIN Person_Hobby ON Hobbies.id = Person_Hobby.hobby_id WHERE person_id = (SELECT id FROM Persons WHERE name = 'Danisovszky Márk Richárd');
SELECT * FROM Pets;
SELECT * FROM Users;
SELECT * FROM Cars;
