--SELECT QUERY FOR THAT FINDS ALL EMPLOYEES WHICH JOB TITLE DO NOT CONTAINS 'engineer'!
-- USE OPERATOR 'NOT LIKE' AND PATTERN '%engineer%'
SELECT FirstName, LastName
FROM Employees
WHERE JobTitle NOT LIKE '%engineer%'