SELECT TOP(5) 
C.CountryName, R.RiverName
FROM Countries AS C
LEFT JOIN CountriesRivers AS CR
    ON CR.CountryCode = C.CountryCode
LEFT JOIN  Rivers AS R
    ON R.Id = CR.RiverId
WHERE ContinentCode = 'AF'
ORDER BY C.CountryName 

