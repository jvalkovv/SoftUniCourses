/*
QUERY that finds all towns that do not start with R, B, or D. 
*/
SELECT *
FROM Towns
WHERE [Name]  NOT LIKE 'R%' AND 
[Name]  NOT LIKE 'B%' AND 
[Name]  NOT LIKE 'D%'
ORDER BY [Name] ASC