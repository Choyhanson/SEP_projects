use Northwind
go

--1.
SELECT DISTINCT e.City
FROM  Employees AS e INNER JOIN
         Customers AS c ON e.City = c.City

--2.
--a)
SELECT DISTINCT City
FROM  Customers
WHERE (City NOT IN
             (SELECT City
           FROM   Employees))
--b)
SELECT City
FROM  Customers
except
SELECT City
FROM  Employees

--3.
SELECT ProductID, SUM(Quantity) AS TotalOrder
FROM  [Order Details]
GROUP BY ProductID

--4.
SELECT c.City, SUM(od.Quantity) AS TotalOrder
FROM  Customers AS c INNER JOIN
         Orders AS o ON c.CustomerID = o.CustomerID INNER JOIN
         [Order Details] AS od ON o.OrderID = od.OrderID
WHERE (c.City IS NOT NULL)
GROUP BY c.City

--5.
--a)
SELECT  City
        FROM   Customers
        GROUP BY City
        HAVING (COUNT(*) = 2)
union
SELECT  City
        FROM   Customers
        GROUP BY City
        HAVING (COUNT(*) > 2)
--b)
SELECT DISTINCT City
FROM  Customers
WHERE (City IN
             (SELECT City
			   FROM   Customers
			   GROUP BY City
			   HAVING (COUNT(*) >= 2)))

--6.
SELECT ContactName
FROM  (SELECT DISTINCT c.ContactName, od.ProductID
        FROM   customers AS c INNER JOIN
                 orders AS o ON c.CustomerID = o.CustomerID INNER JOIN
                 [Order Details] AS od ON od.OrderID = o.OrderID) AS a
GROUP BY ContactName
HAVING (COUNT(ProductID) >= 2)

--7.
SELECT DISTINCT c.ContactName
FROM  customers AS c INNER JOIN
         orders AS o ON c.CustomerID = o.CustomerID
WHERE (c.City <> o.ShipCity)

--8.
with Top5Products as
(
select top 5 ProductID,sum(Quantity)TotalQty
from [Order Details]
group by ProductID
order by sum(Quantity) desc
),
ProductAvgPrice as
(
select ProductID, sum(UnitPrice*Quantity)/sum(Quantity) AvgPrice
from [Order Details]
group by ProductID
),
CitySoldMost as
(
select productid, city
from(select od.ProductID,c.city,
		sum(quantity)CityQty,
		rank()over(partition by od.productid order by sum(quantity) desc)rnk
	from [Order Details] od join orders o on od.OrderID=o.OrderID
	join Customers c on o.CustomerID=c.CustomerID
	group by od.ProductID,c.City)a
where rnk=1
)
SELECT t.ProductID, pavg.AvgPrice, c.City
FROM  Top5Products AS t INNER JOIN
         ProductAvgPrice AS pavg ON t.ProductID = pavg.ProductID INNER JOIN
         CitySoldMost AS c ON c.ProductID = t.ProductID
ORDER BY t.TotalQty DESC

--9.
--a)
SELECT DISTINCT c.City
FROM  customers AS c INNER JOIN
         Employees AS e ON c.city = e.City
WHERE (c.CustomerID NOT IN
             (SELECT customerid
			  FROM   Orders))
--b)
SELECT DISTINCT c.City
FROM  Customers AS c LEFT OUTER JOIN
         orders AS o ON c.CustomerID = o.CustomerID INNER JOIN
         Employees AS e ON c.City = e.City
WHERE (o.CustomerID IS NULL)

--10.
declare @CityESold char(50)
declare @CityCOrder char(50)

select @CityESold = 
(select top 1 e.City
from Orders o join Employees e on o.EmployeeID=e.EmployeeID
group by e.city
order by count(o.OrderID) desc)

select @CityCOrder=
(select top 1 c.city
from customers c join orders o on c.CustomerID=o.CustomerID
join [Order Details] od on o.OrderID=od.OrderID
group by c.city
order by sum(od.Quantity) desc)

select iif(@CityCOrder=@CityESold,@CityCOrder,'Not Exist') TheCityIfExist

/*
--11.How do you remove the duplicates record of a table?
1). I could use GROUP BY function to 'remove' the duplicates records
2). Could create a CTE table first, then add the ROW_Number() on it, delete the row from CTE table
where row_num >1
*/

--12.
SELECT empid
FROM  employee
WHERE (empid NOT IN
             (SELECT mgrid
              FROM   Employees))

--13.
SELECT  deptname
       ,NumEmp AS 'count of employees'
FROM
(
	SELECT  d.deptname
	       ,COUNT(e.empid)NumEmp
	       ,rank()over(order by COUNT(e.empid) desc)rnk
	FROM employee e
	JOIN dept d
	ON e.deptid=d.depid
	GROUP BY  d.deptname
)a
WHERE rnk=1
ORDER BY 1

--14.
SELECT  deptname
       ,empid
       ,salary
FROM
(
	SELECT  d.deptname
	       ,e.salary
	       ,e.empid
	       ,rank()over(partition by d.deptid ORDER BY e.salary desc)rnk
	FROM employee e
	JOIN dept d
	ON e.deptid=d.deptid
)a
WHERE rnk<=3
ORDER BY 1, 3 desc
