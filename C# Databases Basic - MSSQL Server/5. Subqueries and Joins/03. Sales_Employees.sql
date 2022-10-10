SELECT EmployeeID, FirstName, LastName, [Name] AS [DepartmentName]
FROM Employees AS E
JOIN Departments AS D ON E.DepartmentID=D.DepartmentID
WHERE [Name] = 'Sales'
ORDER BY EmployeeID
