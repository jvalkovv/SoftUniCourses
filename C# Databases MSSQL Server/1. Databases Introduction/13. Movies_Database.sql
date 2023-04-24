CREATE DATABASE Movies
USE Movies

CREATE TABLE Directors 
(Id BIGINT NOT NULL PRIMARY KEY IDENTITY(1,1),
DirectorName VARCHAR(30) NOT NULL UNIQUE,
Notes VARCHAR(MAX) NOT NULL,
)

CREATE TABLE Genres  
(Id BIGINT NOT NULL PRIMARY KEY IDENTITY(1,1),
GenreName VARCHAR(30) NOT NULL UNIQUE,
Notes VARCHAR(MAX) NOT NULL,
)

CREATE TABLE Categories   
(Id BIGINT NOT NULL PRIMARY KEY IDENTITY(1,1),
CategoryName VARCHAR(30) NOT NULL UNIQUE,
Notes VARCHAR(MAX) NOT NULL,
)


CREATE TABLE Movies    
(Id BIGINT NOT NULL PRIMARY KEY IDENTITY(1,1),
Title VARCHAR(30) NOT NULL UNIQUE,
DirectorId INT,
CopyrightYear DATE NOT NULL,
[Length] INT,
GenreId INT,
CategoryId INT,
Rating FLOAT,
Notes VARCHAR(MAX) NOT NULL
)

INSERT INTO Directors
(DirectorName, Notes) Values
('Kevin','nqkakuvnote1'),
('Yordan','nqkakuvnote2'),
('Pesho','nqkakuvnote123'),
('Maria','nqkakuvnote1234'),
('Georgi','nqkakuvnote12345')

INSERT INTO Genres
(GenreName, Notes) Values
('Janr1','nqkakuvnote1'),
('Janr2','nqkakuvnote2'),
('Janr3','nqkakuvnote123'),
('Janr4','nqkakuvnote1234'),
('Janr5','nqkakuvnote12345')


INSERT INTO Categories
(CategoryName, Notes) Values
('Categories1','nqkakuvnote1'),
('Categories2','nqkakuvnote2'),
('Categories3','nqkakuvnote123'),
('Categories4','nqkakuvnote1234'),
('Categories5','nqkakuvnote12345')

INSERT INTO Movies
(Title, DirectorId, CopyrightYear, [Length], GenreId, CategoryId, Rating, Notes)
Values
('TITLE1',1,'2020',20,1,1,7.1,'nqkakuvMovienote1'),
('TITLE2',2,'2020',21,2,2,7.2,'nqkakuvMovienote2'),
('TITLE3',3,'2021',22,3,3,7.3,'nqkakuvMovienote123'),
('TITLE4',4,'2021',23,4,4,7.4,'nqkakuvMovienote1234'),
('TITLE5',5,'2022',24,5,5,7.5,'nqkakuvMovienote12345')