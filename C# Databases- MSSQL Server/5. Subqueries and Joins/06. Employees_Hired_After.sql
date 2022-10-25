SELECT FirstName, LastName, HireDate, D.Name AS [DeptName]
FROM Employees AS E
JOIN Departments AS D ON E.DepartmentID=D.DepartmentID
WHERE E.HireDate >'01.01.1999'AND D.Name='Sales' OR D.Name='Finance'
ORDER BY HireDate ASC