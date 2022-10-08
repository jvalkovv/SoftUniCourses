/*
Combine all peak names with all river names, 
so that the LAST LETTER of each peak name is the same as the FIRST LETTER of its corresponding river name. 
Display the peak names, river names, and the obtained mix (mix should be in LOWERCASE). 
Sort the results by the obtained mix.
*/
SELECT Peaks.PeakName, Rivers.RiverName, 
LOWER((Peaks.PeakName) + SUBSTRING(Rivers.RiverName,2,LEN(Rivers.Rivername))) AS 'Mix' 
FROM Peaks
JOIN Rivers
ON RIGHT(Peaks.PeakName,1) = LEFT(Rivers.RiverName,1)
ORDER BY Mix