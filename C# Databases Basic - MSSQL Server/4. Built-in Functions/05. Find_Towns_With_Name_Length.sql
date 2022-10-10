/*
FIND ALL TOWNS WHERE THE TOWN NAME LENGTH IS 5 OR 6 SYMBOL LONG.
USE OPERATOR LEN([column name])
*/
SELECT [Name] 
FROM Towns
WHERE LEN([Name]) = 5 OR LEN([Name]) = 6
ORDER BY [Name] ASC