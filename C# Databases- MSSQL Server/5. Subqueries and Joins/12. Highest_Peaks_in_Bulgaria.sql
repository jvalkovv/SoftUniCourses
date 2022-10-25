SELECT 
MC.CountryCode, M.MountainRange, P.PeakName, P.Elevation
FROM Peaks AS P
JOIN Mountains AS M ON M.Id = P.MountainId
JOIN MountainsCountries AS MC ON MC.MountainId = M.Id
WHERE P.Elevation > 2835 AND MC.CountryCode = 'BG'
ORDER BY P.Elevation DESC