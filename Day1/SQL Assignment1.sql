--1.
SELECT ProductID, Name, Color, ListPrice
FROM  Production.Product

--2.
SELECT ProductID, Name, Color, ListPrice
FROM  Production.Product
WHERE (ListPrice <> 0)

--3.
SELECT ProductID, Name, Color, ListPrice
FROM  Production.Product
WHERE (Color IS NULL)

--4.
SELECT ProductID, Name, Color, ListPrice
FROM  Production.Product
WHERE (Color IS NOT NULL)

--5.
SELECT ProductID, Name, Color, ListPrice
FROM  Production.Product
WHERE (Color IS NOT NULL) AND (ListPrice > 0)

--6.
SELECT Name, Color
FROM  Production.Product
WHERE (Color IS NOT NULL)

--7.
SELECT 'NAME: ' + ISNULL(Name, 'None') + ' -- COLOR: ' + ISNULL(Color, 'None') AS 'Name And Color'
FROM  Production.Product

--8.
SELECT ProductID, Name
FROM  Production.Product
WHERE (ProductID BETWEEN 400 AND 500)

--9.
SELECT ProductID, Name, Color
FROM  Production.Product
WHERE (Color IN ('black', 'blue'))

--10.
SELECT Name
FROM  Production.Product
WHERE (Name LIKE 's%')

--11.
SELECT Name, ListPrice
FROM  Production.Product
ORDER BY Name, ListPrice

--12.
SELECT Name, ListPrice
FROM  Production.Product
WHERE (Name LIKE '[as]%')
ORDER BY Name

--13.
SELECT Name
FROM  Production.Product
WHERE (Name LIKE 'spo[^k]%')
ORDER BY Name

--14.
SELECT DISTINCT Color
FROM  Production.Product
WHERE (Color IS NOT NULL)
ORDER BY Color DESC

--15.
SELECT DISTINCT ProductSubcategoryID, Color
FROM  Production.Product
WHERE (ProductSubcategoryID IS NOT NULL) AND (Color IS NOT NULL)
ORDER BY ProductSubcategoryID, Color

--16.
SELECT ProductSubcategoryID, LEFT(Name, 35) AS Name, Color, ListPrice
FROM  Production.Product
WHERE (Color NOT IN ('red', 'black')) AND (ProductSubcategoryID <> 1) OR
         (Color IN ('Red', 'Black')) AND (ProductSubcategoryID = 1) AND (ListPrice BETWEEN 1000 AND 2000)
ORDER BY ProductSubcategoryID

