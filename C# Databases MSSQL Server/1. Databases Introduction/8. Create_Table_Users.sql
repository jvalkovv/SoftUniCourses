CREATE TABLE Users
(Id BIGINT NOT NULL PRIMARY KEY IDENTITY(1,1),
Username VARCHAR(30) NOT NULL UNIQUE,
[Password] VARCHAR(26) NOT NULL,
ProfilePicture VARBINARY(MAX),
LastLongtime DATETIME,
IsDeleted BIT
)


INSERT INTO Users
(Username,[Password],ProfilePicture,LastLongtime,IsDeleted) Values
('Kevin','nqkakvaparola1',null,'2015-12-08', 'true'),
('Yordan','nqkakvaparola12', null,'2022-09-19', 'false'),
('Pesho','nqkakvaparola123', null, '2022-09-19', 'true'),
('Maria','nqkakvaparola1234', null, '2022-09-18', 'false'),
('Georgi','nqkakvaparola12345', null, '2022-09-17', 'true')

--REMOVE PRIMARY KEY
ALTER TABLE Users
DROP CONSTRAINT PK__Users__3214EC075A97178A

--REMOVE PRIMARY KEY
ALTER TABLE Users
DROP CONSTRAINT UQ__Users__536C85E483AF474A

--- ADD PRIMARY KEYS TO TWO CONDITIONS
ALTER TABLE Users
ADD CONSTRAINT PK_IdUsername PRIMARY KEY(Id, Username)

--CHECH PASSWORD LENGHT
ALTER TABLE Users
ADD CONSTRAINT CH_PasswordIsAtLeast5Symbol CHECK (LEN([Password])>5) 

--SET LAST LOGIN TO DEFAULT
ALTER TABLE Users
ADD CONSTRAINT DF_LastLoginTime DEFAULT GETDATE() FOR LastLongtime

--REMOVE TWO PRIMARY KEY
ALTER TABLE Users
DROP CONSTRAINT PK_IdUsername

--ADD ONE PRIMARY KEY
ALTER TABLE Users
ADD CONSTRAINT PK_Id PRIMARY KEY(Id)

--CHECK USERNAME LENGHT
ALTER TABLE Users
ADD CONSTRAINT CH_UsernameIsAtLeast3Symbol CHECK (LEN(Username)>3) 