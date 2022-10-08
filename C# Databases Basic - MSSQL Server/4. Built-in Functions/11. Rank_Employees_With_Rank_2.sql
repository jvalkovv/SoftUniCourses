/*
DENSE_RANK -> computes the rank of a row in an ordered group of rows and returns the rank as a NUMBER !
PARTITION on GROUPS BY SALARAY AND THEN ORDER THEM BY EmployeeID as Rank(name of column).
WE CREATE NEW TABLE(NewTable) only in our SELECT statement TO CAN USE NEW COLUMN (RANK) IN OUR CONDITION!
*/
SELECT * 
FROM  (
        SELECT EmployeeID, FirstName, LastName, Salary,
        DENSE_RANK() OVER (PARTITION BY Salary ORDER BY EmployeeID) AS [Rank]  
        FROM Employees   
        WHERE Salary BETWEEN 10000 AND 50000  
      ) AS NewTable
WHERE NewTable.Rank = 2
ORDER BY Salary DESC
