SELECT E.EmployeeID, E.FirstName,
CASE 
WHEN P.StartDate > '01.01.2005' THEN NULL
ELSE P.Name 
END AS ProjectName
FROM Employees AS E
JOIN EmployeesProjects AS EP ON E.EmployeeID = EP.EmployeeID
JOIN Projects AS P ON EP.ProjectID = P.ProjectID
WHERE E.EmployeeID = 24
