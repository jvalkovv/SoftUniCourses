SELECT TOP(50) FirstName, LastName, [Name], AddressText
FROM Employees AS E
JOIN Addresses AS A ON A.AddressID = E.AddressID
JOIN Towns AS T ON T.TownID = A.TownID
ORDER BY FirstName ASC, LastName ASC