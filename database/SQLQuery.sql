
 -- Táblák létrehozása --
CREATE TABLE Users(
	username VARCHAR(50) PRIMARY KEY,
	password VARCHAR(50) NOT NULL,
	logged BIT DEFAULT 0 
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

CREATE TABLE Refresh(
	id INT DEFAULT 1,
	last_modify_time DATETIME NULL
);

CREATE TABLE Tokens(
	token CHAR(50) NOT NULL
);