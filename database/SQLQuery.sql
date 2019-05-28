/*DROP TABLE Person_Parent;
DROP TABLE Person_Hobby;
DROP TABLE Person_Pet;
DROP TABLE Users;
DROP TABLE Parents;
DROP TABLE Hobbies;
DROP TABLE Jobs;
DROP TABLE Persons;
DROP TABLE Cars;
DROP TABLE Pets;*/

CREATE TABLE Users(
	username VARCHAR(50) PRIMARY KEY,
	password VARCHAR(50) NOT NULL
);

CREATE TABLE Parents(
	id INT IDENTITY(1,1) PRIMARY KEY,
	name VARCHAR(250) NOT NULL,
	birth_day DATE NOT NULL
);

CREATE TABLE Hobbies(
	id INT IDENTITY(1,1) PRIMARY KEY,
	description VARCHAR(250)
);

CREATE TABLE Jobs(
	id INT IDENTITY(1,1) PRIMARY KEY,
	workplace_name VARCHAR(250) NOT NULL,
	job VARCHAR(120) NOT NULL,
	description VARCHAR(250) NULL
);

CREATE TABLE Persons(
	id INT IDENTITY(1,1) PRIMARY KEY,
	name VARCHAR(250) NOT NULL,
	birth_day DATE NOT NULL,
	job_id INT NOT NULL,
	salary INT NULL,
	FOREIGN KEY(job_id) REFERENCES Jobs(id)
);

CREATE TABLE Cars(
	licence_plate VARCHAR(7) PRIMARY KEY,
	manufacurer VARCHAR(120) NOT NULL,
	model VARCHAR(50) NOT NULL,
	color VARCHAR(50) NOT NULL,
	person_id INT NULL,
	FOREIGN KEY(person_id) REFERENCES Persons(id)
);

CREATE TABLE Pets(
	id INT IDENTITY(1,1) PRIMARY KEY,
	species VARCHAR(120) NOT NULL,
	name VARCHAR(120) NOT NULL
);

CREATE TABLE Person_Parent(
	person_id INT NOT NULL,
	parent_id INT NOT NULL,
	FOREIGN KEY(person_id) REFERENCES Persons(id),
	FOREIGN KEY(parent_id) REFERENCES Parents(id)
);

CREATE TABLE Person_Hobby(
	person_id INT NOT NULL,
	hobby_id INT NOT NULL,
	FOREIGN KEY(person_id) REFERENCES Persons(id),
	FOREIGN KEY(hobby_id) REFERENCES Hobbies(id)
);

CREATE TABLE Person_Pet(
	person_id INT NOT NULL,
	pet_id INT NOT NULL,
	FOREIGN KEY(person_id) REFERENCES Persons(id),
	FOREIGN KEY(pet_id) REFERENCES Pets(id)
);
