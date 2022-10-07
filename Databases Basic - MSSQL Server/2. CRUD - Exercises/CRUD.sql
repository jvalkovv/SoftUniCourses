--USE SoftUni

--Select everything from Departments TABLE
SELECT * FROM Departments

--Select only column "NAME" from Departments TABLE
SELECT Name
FROM Departments

--Select few column from Employees TABLE
SELECT FirstName, LastName, Salary
FROM Employees

--Select few column from Employees TABLE
SELECT FirstName, MiddleName, LastName
FROM Employees

-- Concatenate two column with operator "+". 
-- This (+) operation make new column without NAME and with command "AS" we can set column NAME !!! 
SELECT FirstName +'.' + LastName+'@'+'softuni.bg' AS [Full Email Address]
FROM Employees

--USE "DISTINCT" IF YOU WANT to list the different (distinct) values. SHOWS ONLY NOT DUPLICATE values;
SELECT DISTINCT Salary
FROM Employees

--SELECTION FROM TABLE WITH CONDITION !! USE 'WHERE'
SELECT * FROM Employees
WHERE JobTitle = 'Sales Representative'

--USE OPERATOR 'AND'
SELECT FirstName, LastName, JobTitle
FROM Employees
WHERE Salary BETWEEN 20000 AND 30000

--USE OPERATOR 'OR' FOR MORE CONDITIONS
SELECT FirstName + ' ' + MiddleName + ' ' + LastName AS [Full Name]
FROM Employees
WHERE Salary = 25000 OR Salary = 14000 OR Salary = 12500 OR Salary = 23600

--RIGHT(FIRSTNAME, 2) -> THE LAST TWO SYMBOL IN FIRSTNAME
--LEFT(FIRSTNAME, 2) -> THE FIRST TWO SYMBOL IN FIRSTNAME

--Ctrl Shift R -> clear cache

--- SELECT PEOPLE WHICH HAVEN'T MANAGER !
SELECT FirstName, LastName
FROM Employees
WHERE ManagerID IS NULL

---WHERE SALARY IS MORE THAN CONDITION
SELECT FirstName, LastName, Salary
FROM Employees
WHERE Salary > 50000
ORDER BY Salary DESC

--TOP 5 VALUES ORDERED BY SALARY
SELECT TOP 5 FirstName, LastName
FROM Employees
ORDER BY Salary DESC

--EVERYONE EMPLOYEES WITHOUT DEPARTMENT = 4(MARKETING)
SELECT FirstName, LastName
FROM Employees
WHERE NOT  DepartmentID = 4


--• SORT ALL RECORDS IN EMPLOYEES TABLE BY FOLLOWING CRITERIA:
--•	By salary in decreasing order
--•	Then by the first name alphabetically
--•	Then by the last name descending
--•	Then by middle name alphabetically
SELECT * 
FROM Employees
ORDER BY Salary DESC, FirstName ASC, LastName DESC, MiddleName ASC

--CREATE A VIEW - V_EmployeesSalaries with first name, last name, and salary for each employee.
CREATE VIEW [V_EmployeesSalaries] AS
SELECT FirstName, LastName, Salary
FROM Employees

-- CREATE A VIEW - "V_EmployeeNameJobTitle" with full employee name and job title. When the middle name is NULL replace it with an empty string ('').
CREATE VIEW [V_EmployeeNameJobTitle] AS
SELECT FirstName + ' ' + ISNULL(MiddleName, '') + ' ' + LastName 
AS [Full Name], JobTitle
FROM Employees


--USE "DISTINCT" IF YOU WANT to list the different (distinct) values. SHOWS ONLY NOT DUPLICATE values;
SELECT DISTINCT JobTitle
FROM Employees

/*
Finds the first 10 projects which were started, select all information about them, and sort the result by starting date, then by name.
*/
SELECT TOP 10 *
FROM Projects
ORDER BY StartDate ASC, [Name] ASC

/*
Finds the last 7 hired employees, select their first, last name, and hire date.
*/
SELECT TOP 7 FirstName, LastName, HireDate
FROM Employees
ORDER BY HireDate DESC

/*Increases salaries by 12% of all employees that work in the ether Engineering, Tool Design, Marketing, or Information Services departments. As a result, select and display only the "Salaries" column from the Employees table. After that exercise, you should restore the database to the original data.
*/
UPDATE Employees
SET Salary = Salary*1.12
WHERE DepartmentID IN 
(SELECT DepartmentID FROM Departments
 WHERE Name IN ('Engineering', 'Tool Design', 'Marketing', 'Information Services'))

SELECT Salary
FROM Employees

--USE Geography

--Display all mountain peaks in alphabetical order.
SELECT PeakName
FROM Peaks
ORDER BY PeakName ASC

/*
Find the 30 biggest countries by population located in Europe. Display the "CountryName" and "Population". 
Sort the results by population (from biggest to smallest), then by country alphabetically.
*/
SELECT TOP 30 CountryName, [Population]
FROM Countries
 WHERE Countries.ContinentCode IN 
(SELECT Continents.ContinentCode FROM Continents
 WHERE Continents.ContinentName IN ('Europe'))
 ORDER BY [Population] DESC

 /*
 Find all countries along with information about their currency. Display the "CountryName", "CountryCode", and information about its "Currency": 
 either "Euro" or "Not Euro". Sort the results by country name alphabetically.
 */
SELECT 	CountryName, CountryCode, 
	IIF(Currencies.CurrencyCode = 'EUR', 'Euro', 
	'Not Euro') AS Currency
FROM Countries 
LEFT JOIN Currencies ON Currencies.CurrencyCode = Countries.CurrencyCode
ORDER BY CountryName

--USE Diablo

SELECT [Name]
FROM Characters
ORDER BY Characters.Name ASC