SELECT DepositGroup, MagicWandCreator AS [MagicWandCreator], 
       MIN(DepositCharge) AS MinDepositCharge 
FROM WizzardDeposits
GROUP BY DepositGroup, MagicWandCreator
ORDER BY MagicWandCreator, DepositGroup