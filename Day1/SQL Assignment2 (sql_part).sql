use AdventureWorks2019
go
--1. How many products can you find in the Production.Product table?
SELECT COUNT(DISTINCT ProductID) AS TotalProductNum
FROM  Production.Product

--2.
SELECT COUNT(DISTINCT ProductSubcategoryID) AS Num
FROM  Production.Product 
WHERE (ProductSubcategoryID IS NOT NULL)

--3.
SELECT ProductSubcategoryID, COUNT(*) AS CountedProducts
FROM  Production.Product
WHERE (ProductSubcategoryID IS NOT NULL)
GROUP BY ProductSubcategoryID

--4.
SELECT COUNT(*) AS NumNoSubcategory
FROM  Production.Product
WHERE (ProductSubcategoryID IS NULL)
--or
SELECT COUNT(ISNULL(ProductSubcategoryID, 0)) AS Expr1
FROM  Production.Product
WHERE (ProductSubcategoryID IS NULL)

--5.
SELECT SUM(Quantity) AS SumOfProduct
FROM  Production.ProductInventory

--6.
SELECT ProductID, SUM(Quantity) AS TheSum
FROM  Production.ProductInventory
WHERE (LocationID = 40)
GROUP BY ProductID
HAVING (SUM(Quantity) < 100)

--7.
SELECT Shelf, ProductID, SUM(Quantity) AS TheSum
FROM  Production.ProductInventory
WHERE (LocationID = 40)
GROUP BY ProductID, Shelf
HAVING (SUM(Quantity) < 100)

--8.
SELECT AVG(Quantity) AS AvgQuan
FROM  Production.ProductInventory
WHERE (LocationID = 10)

--9.
SELECT ProductID, shelf, avg(Quantity) AS TheAvg
FROM  Production.ProductInventory
GROUP BY shelf,ProductID

--10.
SELECT ProductID, shelf, avg(Quantity) AS TheAvg
FROM  Production.ProductInventory
where Shelf is not null
GROUP BY shelf,ProductID

--11.
SELECT Color, Class, COUNT(*) AS TheCount, AVG(ListPrice) AS AvgPrcie
FROM  Production.Product
WHERE (Color IS NOT NULL) OR
         (Class IS NOT NULL)
GROUP BY Color, Class

--12.
SELECT c.Name AS Country, s.Name AS Province
FROM  Person.CountryRegion AS c INNER JOIN
         Person.StateProvince AS s ON c.CountryRegionCode = s.CountryRegionCode

--13.
SELECT c.Name AS Country, s.Name AS Province
FROM  Person.CountryRegion AS c INNER JOIN
         Person.StateProvince AS s ON c.CountryRegionCode = s.CountryRegionCode
where c.Name in ('Germany','Canada')


use Northwind
go


--14.
declare @today int
select @today = year(getdate())
print @today
SELECT p.ProductName
FROM  Products AS p INNER JOIN
         [Order Details] AS o ON p.ProductID = o.ProductID INNER JOIN
         Orders AS d ON o.OrderID = d.OrderID
WHERE (o.Quantity > 0) AND (YEAR(d.OrderDate) >= @today - 25)

--15.
SELECT TOP (5) s.ShipPostalCode, SUM(o.Quantity) AS NumSold
FROM  [Order Details] AS o INNER JOIN
         Orders AS s ON o.OrderID = s.OrderID
WHERE (s.ShipPostalCode IS NOT NULL)
GROUP BY s.ShipPostalCode
ORDER BY NumSold DESC

--16.
SELECT TOP (5) s.ShipPostalCode, SUM(o.Quantity) AS NumSold
FROM  [Order Details] AS o INNER JOIN
         Orders AS s ON o.OrderID = s.OrderID
WHERE (s.ShipPostalCode IS NOT NULL) AND (YEAR(s.OrderDate) >= @today - 25)
GROUP BY s.ShipPostalCode
ORDER BY NumSold DESC

--17.
SELECT City, COUNT(CustomerID) AS NumCustomers
FROM  Customers
GROUP BY City

--18.
SELECT City, COUNT(CustomerID) AS NumCustomers
FROM  Customers
GROUP BY City
HAVING (COUNT(CustomerID) > 2)

--19.
SELECT c.ContactName, s.ShippedDate
FROM  Orders AS s INNER JOIN
         Customers AS c ON s.CustomerID = c.CustomerID
WHERE (s.ShippedDate > '1998/1/1')

--20.
select c.ContactName, max(s.ShippedDate)MostRecentOrderDate
from Northwind.dbo.Customers c join Northwind.dbo.Orders s on c.CustomerID=s.CustomerID
group by c.ContactName

--21.
select c.ContactName, sum(o.Quantity)ProductBought
from Northwind.dbo.Customers c join Northwind.dbo.orders s on c.CustomerID=s.CustomerID
join Northwind.dbo.[Order Details] o on s.OrderID=o.OrderID
group by c.ContactName

--22.
select c.CustomerID
from Northwind.dbo.Customers c join Northwind.dbo.orders s on c.CustomerID=s.CustomerID
join Northwind.dbo.[Order Details] o on s.OrderID=o.OrderID
group by c.CustomerID
having sum(o.Quantity)>100


--23.
select distinct supp.CompanyName 'Supplier Company Name', ship.CompanyName 'Shipping Company Name'
from Northwind.dbo.Suppliers supp join Northwind.dbo.Products p on supp.SupplierID=p.SupplierID
join Northwind.dbo.[Order Details] o on p.ProductID=o.ProductID
join Northwind.dbo.Orders s on o.OrderID=s.OrderID
join Northwind.dbo.Shippers ship on s.ShipVia=ship.ShipperID
group by supp.CompanyName,ship.CompanyName

--24.
select distinct s.OrderDate, p.ProductName
from Northwind.dbo.Products p join Northwind.dbo.[Order Details] o on p.ProductID=o.ProductID
join Northwind.dbo.Orders s on o.OrderID=s.OrderID

--25.
select e1.EmployeeID EID1, e2.EmployeeID EID2
from Northwind.dbo.Employees e1 join Northwind.dbo.Employees e2 on e1.EmployeeID < e2.EmployeeID
where e1.Title=e2.Title

--26.
select ReportsTo as ManagerId
from Northwind.dbo.Employees
where ReportsTo is not null
group by ReportsTo
having COUNT(ReportsTo)>2

--27.
select distinct City, ContactName, iif(1<2,'Supplier','Customer')Type
from Northwind.dbo.Suppliers
union
select distinct City, ContactName, iif(1>2,'Supplier','Customer')Type
from Northwind.dbo.Customers
order by 1,2

--28.
select T1.F1, T2.F2
from T1 join T2 on T1.F1=T2.F2

--result output: 
--T1.F1		T2.F2
--  2		  2
--  3		  3

--29.
select T1.F1, T2.F2
from T1 left join T2 on T1.F1=T2.F2

--result output: 
--T1.F1		T2.F2
--  1		 NULL
--  2		  2
--  3		  3

select T1.F1, T2.F2
from T2 left join T1 on T1.F1=T2.F2

--result output: 
--T1.F1		T2.F2
--  2		  2
--  3		  3
-- NULL		  4
