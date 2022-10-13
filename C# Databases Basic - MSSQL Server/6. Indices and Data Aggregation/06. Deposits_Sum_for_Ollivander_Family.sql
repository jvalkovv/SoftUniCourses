SELECT DepositGroup, SUM(DepositAmount) AS TotalSum
FROM WizzardDeposits AS WD
WHERE WD.MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup
