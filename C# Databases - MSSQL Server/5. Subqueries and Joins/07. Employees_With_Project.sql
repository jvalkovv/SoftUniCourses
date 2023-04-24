SELECT TOP(5) E.EmployeeID, E.FirstName, P.Name AS ProjectName
FROM Employees AS E
JOIN EmployeesProjects AS EP ON E.EmployeeID = EP.EmployeeID
LEFT OUTER JOIN Projects AS P ON EP.ProjectID = P.ProjectID
WHERE P.StartDate >= '2002.08.13' AND P.EndDate IS NULL
ORDER BY E.EmployeeID ASC
