/*
-Show All Games with Duration and Part of the Day
WE USE 'DATEPART' TO SEPARETE THE HOURS FROM DATETIME.
NEXT WE USE 'CASE' STATEMENT WITH COUPLE CONDITIONS(WHEN).
*/
SELECT [Name] AS Game,
CASE
    WHEN DATEPART(HOUR,[Start]) BETWEEN 0 AND 11 THEN 'Morning'
	WHEN DATEPART(HOUR,[Start]) BETWEEN 12 AND 17 THEN 'Afternoon'
	WHEN DATEPART(HOUR,[Start]) BETWEEN 18 AND 23 THEN 'Evening'
END AS 'Part of the Day',
CASE
    WHEN Duration <= 3 THEN 'Extra Short'
	WHEN Duration BETWEEN 4 AND 6 THEN 'Short'
	WHEN Duration > 6 THEN 'Long'
	ELSE 'Extra Long'
END AS 'Duration'
FROM Games
ORDER BY Game ASC, Duration ASC
