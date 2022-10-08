/*
CREATE A VIEW - V_EmployeesHiredAfter2000 with first name AND last name, 
FOR all employees HIRED AFTER THE YEAR 2000
*/
CREATE VIEW [V_EmployeesHiredAfter2000] AS
SELECT FirstName, LastName
FROM Employees
WHERE HireDate > '2000-12-31'

