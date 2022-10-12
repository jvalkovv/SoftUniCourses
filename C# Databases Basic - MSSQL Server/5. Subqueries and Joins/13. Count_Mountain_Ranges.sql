SELECT 
C.CountryCode, COUNT(MC.MountainId) AS [MountainRange]
FROM Countries AS C
 JOIN MountainsCountries AS MC 
     ON C.CountryCode = MC.CountryCode
WHERE 
C.CountryName IN ('United States', 'Russia', 'Bulgaria')
GROUP BY C.CountryCode
ORDER BY [MountainRange] DESC