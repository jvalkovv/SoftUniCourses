SELECT TOP(50)
E.EmployeeID, 
E.FirstName + ' ' + E.LastName AS[EmployeeName], 
MN.FirstName + ' '+ MN.LastName [ManagerName],
DP.Name AS [DepartmentName]
FROM Employees AS E 
JOIN Departments AS DP ON DP.DepartmentID = E.DepartmentID
JOIN Employees AS MN ON MN.EmployeeID=E.ManagerID
ORDER BY E.EmployeeID