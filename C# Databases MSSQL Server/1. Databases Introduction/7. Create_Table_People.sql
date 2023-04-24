USE Minions

CREATE TABLE People
(
Id INT PRIMARY KEY IDENTITY,
[Name] VARCHAR(200) NOT NULL, 
Picture VARBINARY(max), 
Height DECIMAL(5,2),
[Weight] DECIMAL(5,2),
Gender VARCHAR(1) NOT NULL CHECK(Gender='m' OR Gender='f'),
Birthdate DATE NOT NULL,
Biography VARCHAR,
)

INSERT INTO People
(Name,Picture,Height,Weight,Gender,Birthdate,Biography) Values
('Kevin',Null,1.70,80.99,'m','1989-10-03',Null),
('Yordan',Null,1.71,80.3,'m','1996-08-17',Null),
('Pesho',Null,1.55,33.00,'m','1997-05-15',Null),
('Maria',Null,1.65,55.55,'f','1999-11-11',Null),
('Georgi',Null,1.85,90.00,'m','1983-07-22',Null)
