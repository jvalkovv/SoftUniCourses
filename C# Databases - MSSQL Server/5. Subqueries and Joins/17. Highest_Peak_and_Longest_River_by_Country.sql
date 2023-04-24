SELECT TOP(5) C.CountryName, MAX(P.Elevation) AS [HighestPeakElevation], 
            MAX(R.Length) AS [LongestRiverLength]
FROM Countries AS C
LEFT OUTER JOIN MountainsCountries AS MC 
             ON C.CountryCode = MC.CountryCode
LEFT OUTER JOIN Peaks AS P
            ON P.MountainId = MC.MountainId
LEFT OUTER JOIN CountriesRivers AS CR 
			ON C.CountryCode = CR.CountryCode
LEFT OUTER JOIN Rivers AS R 
			ON CR.RiverId = R.Id
GROUP BY C.CountryName
ORDER BY [HighestPeakElevation] DESC, [LongestRiverLength] DESC, C.CountryName