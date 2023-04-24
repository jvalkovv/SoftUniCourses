SELECT TOP (5) WITH TIES C.CountryName, 
				ISNULL(P.PeakName, '(no highest peak)') AS 'HighestPeakName', 
				ISNULL(MAX(P.Elevation), 0) AS 'HighestPeakElevation', 
				ISNULL(M.MountainRange, '(no mountain)') AS [Mountain]
FROM Countries AS C
LEFT JOIN MountainsCountries AS MC 
					ON C.CountryCode = MC.CountryCode
LEFT JOIN Mountains AS M 
					ON MC.MountainId = M.Id
LEFT JOIN Peaks AS P 
					ON M.Id = P.MountainId
GROUP BY C.CountryName, P.PeakName, M.MountainRange
ORDER BY C.CountryName, P.PeakName