SELECT COUNT(C.CountryCode) as [CountryCount]
FROM Countries as C
LEFT JOIN MountainsCountries as MC 
ON C.CountryCode = MC.CountryCode
WHERE MC.MountainId IS NULL;