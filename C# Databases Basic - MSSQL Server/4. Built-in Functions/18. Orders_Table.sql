/*
WE CREATE TABLE ORDERS AND INSERT SOME VALUES IN IT.
Consider that the payment for that order must be accomplished within 3 days after the order date.
Also the delivery date is up to 1 month.
*/
CREATE TABLE Orders
(
Id INT IDENTITY,
ProductName VARCHAR(20),
OrderDate DATETIME
)

INSERT INTO Orders VALUES
('Butter',	'2016-09-19 00:00:00.000'),
('Milk'	,'2016-09-30 00:00:00.000' ),
('Cheese'	,'2016-09-04 00:00:00.000'),
('Bread'	,'2015-12-20 00:00:00.000'),
('Tomatoes',	'2015-12-30 00:00:00.000')
/*
WE USE 'DATEADD' TO COMPLETE THE CONDITION.
DATEADD(interval, increment int, expression(currentdate))
*/
SELECT ProductName, OrderDate, 
    DATEADD(DAY,3,OrderDate) AS [Pay Due],
    DATEADD(MONTH,1,OrderDate) AS [Deliver Due]
    FROM Orders
