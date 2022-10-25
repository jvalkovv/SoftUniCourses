SELECT 
E.EmployeeID, 
E.FirstName,
E.ManagerID, 
MN.FirstName AS [ManagerName]
FROM Employees AS E
JOIN Employees AS MN ON MN.EmployeeID=E.ManagerID
WHERE E.ManagerID IN (3,7)
ORDER BY E.EmployeeID ASC
