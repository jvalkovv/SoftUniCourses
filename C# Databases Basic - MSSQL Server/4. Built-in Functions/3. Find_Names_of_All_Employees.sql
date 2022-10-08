SELECT FirstName
FROM Employees
WHERE HireDate BETWEEN '1995/01/01' AND '2005/12/31' AND 
DepartmentID=3 OR DepartmentID = 10