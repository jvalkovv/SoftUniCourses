/*
The start date should be in the following format: "yyyy-MM-dd". 
WE NEED TO FORMAT [Start] AS 'yyyy-MM-dd' WITHOUT TIME
*/ 
SELECT TOP(50) [Name], FORMAT([Start],'yyyy-MM-dd') AS [Start]
FROM Games
WHERE [Start] BETWEEN '2011' AND '2012-12-31'
ORDER BY [Start] ASC, [Name] ASC
