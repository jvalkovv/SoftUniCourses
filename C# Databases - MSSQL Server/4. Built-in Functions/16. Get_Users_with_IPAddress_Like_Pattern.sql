/*
***.1^.^.*** == ___.1_%._%.___
*/
SELECT Username, IpAddress
FROM Users
WHERE IpAddress LIKE '___.1_%._%.___'
ORDER BY Username ASC