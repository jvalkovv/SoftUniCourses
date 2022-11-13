CREATE DATABASE CarRental

CREATE TABLE Categories
(Id BIGINT NOT NULL PRIMARY KEY IDENTITY(1,1),
CategoryName VARCHAR(MAX) NOT NULL,
DailyRate FLOAT,
WeeklyRate FLOAT,
MonthlyRate FLOAT,
WeekendRate FLOAT)

CREATE TABLE Cars
(Id BIGINT NOT NULL PRIMARY KEY IDENTITY(1,1),
PlateNumber VARCHAR(MAX) NOT NULL,
Manufacturer VARCHAR(MAX) NOT NULL,
Model VARCHAR(MAX) NOT NULL,
CarYear DATE NOT NULL,
CategoryId INT NOT NULL,
Doors INT NOT NULL,
Picture VARCHAR(MAX),
Condition VARCHAR(MAX),
IsAvailable BIT NOT NULL)

CREATE TABLE Employees
(Id BIGINT NOT NULL PRIMARY KEY IDENTITY(1,1),
FirstName VARCHAR(MAX) NOT NULL,
LastName VARCHAR(MAX) NOT NULL,
Title VARCHAR(MAX),
Notes VARCHAR(MAX)
)

CREATE TABLE Customers
(Id BIGINT NOT NULL PRIMARY KEY IDENTITY(1,1),
DriverLicenceNumber VARCHAR(MAX) NOT NULL,
FullName VARCHAR(MAX) NOT NULL,
[Address] VARCHAR(MAX) NOT NULL,
City VARCHAR(MAX) NOT NULL,
ZIPCode INT NOT NULL,
Notes VARCHAR(MAX)
)

CREATE TABLE RentalOrders
(Id BIGINT NOT NULL PRIMARY KEY IDENTITY(1,1),
EmployeeId INT NOT NULL,
CustomerId INT NOT NULL,
CarId INT NOT NULL,
TankLevel FLOAT NOT NULL,
KilometrageStart FLOAT NOT NULL,
KilometrageEnd FLOAT NOT NULL,
TotalKilometrage FLOAT NOT NULL,
StartDate DATE NOT NULL,
EndDate DATE NOT NULL,
TotalDays INT NOT NULL,
RateApplied FLOAT NOT NULL,
TaxRate FLOAT NOT NULL,
OrderStatus VARCHAR(MAX) NOT NULL,
Notes VARCHAR(MAX)
)

INSERT INTO Categories
(CategoryName, DailyRate, WeeklyRate, MonthlyRate, WeekendRate) Values
('Categotry1',7,49,210,14),
('Categotry2',8,56,240,16),
('Categotry3',9,63,270,18)

INSERT INTO Cars
(PlateNumber, Manufacturer, Model, CarYear, CategoryId, Doors, Picture, Condition, IsAvailable) VALUES
('CC8495AT', 'MERCEDES-BENZ', 'W204', '2007', 3, 4, NULL, NULL, 'true'),
('CC8496AT', 'MERCEDES-BENZ', 'W204', '2007', 1, 4, NULL, NULL, 'false'),
('CC8497AT', 'MERCEDES-BENZ', 'W204', '2007', 2, 4, NULL, NULL, 'false')

INSERT INTO Employees
(FirstName, LastName, Title, Notes) VALUES
('YORDAN1', 'VALKOV1', NULL, NULL),
('YORDAN2', 'VALKOV2', NULL, NULL),
('YORDAN3', 'VALKOV3', NULL, NULL)

INSERT INTO Customers
(DriverLicenceNumber, FullName, [Address], City, ZIPCode, Notes) VALUES
('123', 'YORDAN','VARNA', 'VARNA', 9000, NULL),
('123456', 'YORDAN1','VARNA1', 'VARNA1', 9001, NULL),
('123456789', 'YORDAN2','VARNA2', 'VARNA2', 9002, NULL)

INSERT INTO RentalOrders
(EmployeeId, CustomerId, CarId, TankLevel, 
KilometrageStart, KilometrageEnd, TotalKilometrage, 
StartDate, EndDate, TotalDays, RateApplied, TaxRate, OrderStatus, Notes) VALUES
(1,1,1,50,100,110, 10, '01-09-2022', '02-09-2022', 1, 1.1, 5.1, 'INSELL1', NULL),
(2,2,2,60,100,111, 11, '01-09-2022', '03-09-2022', 2, 1.2, 5.2, 'INSELL2', NULL),
(3,3,3,70,100,112, 12, '01-09-2022', '04-09-2022', 3, 1.3, 5.3, 'INSELL3', NULL)
