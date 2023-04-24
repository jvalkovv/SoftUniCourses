SELECT MIN(AVG) AS [MinAverageSalary]
	 FROM 
	 (
	 SELECT AVG(Salary) AS [AVG]
	 FROM Employees
	 GROUP BY DepartmentID
	 )
	 AS AverageSalary
