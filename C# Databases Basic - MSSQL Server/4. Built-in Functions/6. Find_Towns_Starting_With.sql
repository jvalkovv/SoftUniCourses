/*
QUERY that finds all towns that do  start with M, K, B or E. 
*/
SELECT *
FROM Towns
WHERE [Name]   LIKE 'M%' OR 
[Name]   LIKE 'K%' OR 
[Name]   LIKE 'B%' OR
[Name]   LIKE 'E%'
ORDER BY [Name] ASC