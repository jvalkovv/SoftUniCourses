/*
Display the username and email provider. 
Sort the results by email provider alphabetically, then by username. 
!!!WE USE SUBSTRING AND CHARINDEX!!!
*/
SELECT Username, SUBSTRING(Email,CHARINDEX('@',Email,1)+1,LEN(Email)) 
AS 'Email Provider' 
FROM Users
ORDER BY [Email Provider], Username