/*
Find all countries that hold the letter 'A' at least 3 times in their name (case-insensitively). 
Sort the result by ISO code and display the "Country Name" and "ISO Code". 
USING OPERATOR LIKE AND PATTERN '%a%a%a%'
*/
SELECT CountryName, IsoCode
FROM Countries
WHERE CountryName LIKE '%a%a%a%'
ORDER BY IsoCode ASC