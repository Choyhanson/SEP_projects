--1.
begin tran
--a)
insert Region values (5,'Middle Earth')
--b)
insert into Territories  
	select 12345,'Gondor',
	 RegionID from Region where RegionDescription='Middle Earth'
--c)
insert into Employees
	select 'King','Aragron',null,'Mr.',null,null,null,TerritoryDescription,null,null,null,null,null,null,null,null,null
	from Territories
	where TerritoryDescription='Gondor'

--2.
UPDATE Territories
SET     TerritoryDescription = 'Arnor'
WHERE (TerritoryDescription = 'Gondor')

save tran tst
--Lock region, territory, EmployeeTerritory tables
select top 1 1 
from Territories t with (tablockx) 
join Region r with (tablockx) on t.RegionID=r.RegionID 
join EmployeeTerritories et with (tablockx) on et.TerritoryID=t.TerritoryID

rollback tran tst

--3.
delete Territories where TerritoryDescription='Arnor'

delete Region where RegionDescription='middle earth'

--4.
create view view_product_order_Choy
as
select p.ProductName, 
	(select sum(od.Quantity) from [Order Details]od where od.ProductID=p.ProductID)TotalQty
from Products p 

--5. 
create procedure sp_product_order_quantity_Choy 
	(@ProductId int, @TotalQty int output)
as
begin
	select @TotalQty=sum(Quantity)
	from [Order Details]
	where ProductID=@ProductId
end

--6.
create procedure sp_product_order_city_Choy 
	(@ProductName varchar(40))
as
begin
	select Top 5 o.ShipCity Top5Cities, sum(od.Quantity)TotalOrderQty
	from [Order Details] od join orders o on od.OrderID=o.OrderID
	join Products p on od.ProductID=p.ProductID
	where p.ProductName=@ProductName
	group by o.ShipCity
	order by 2 desc
end

--7.
create proc sp_move_employees_Choy 
(@Tname varchar(40),@TnameNew varchar(40),@region varchar(20))
as
begin tran

declare @NumCity int, @TIDcity int
select  @NumCity=count(t.TerritoryID)
from EmployeeTerritories et join Territories t on et.TerritoryID=t.TerritoryID
where t.TerritoryDescription=@Tname
select @TIDcity=TerritoryID from Territories where TerritoryDescription=@Tname

if @NumCity>0
begin
	if (@Tname not in (select TerritoryDescription from Territories))
	begin
		declare @Tid int = 13131
		while (@tid in (select TerritoryID from Territories))
		begin
			set @tid=@tid+1
			print @tid
		end
		insert into Territories select @Tid,@TnameNew, regionid from Region where RegionDescription=@region
	end
	else
	begin
		set @tid = (select TerritoryID from Territories where TerritoryDescription=@TnameNew)
	end
	update EmployeeTerritories set TerritoryID=@Tid where TerritoryID=@TIDcity
end
commit
go

--8.
create trigger trg_after_insert_emp on EmployeeTerritories
after insert
as
begin 
	declare @NumSP int, @SPID int, @TroyID int
	select @NumSP=count(*) 
	from EmployeeTerritories et join Territories t on et.TerritoryID=t.TerritoryID
	where t.TerritoryDescription='Stevens Point'
	select @SPID=TerritoryID
	from Territories
	where TerritoryDescription='Stevens Point'
	select @TroyID=TerritoryID
	from Territories
	where TerritoryDescription='Troy'
	if @NumSP>100
	begin
		update EmployeeTerritories 
		set TerritoryID=@TroyID
		where TerritoryID=@SPID
	end
end

--9.
create table people_Choy (Id int, Name varchar(50), City int)
create table city_Choy (Id int, City varchar(40))

insert city_Choy values
(1,'Seattle'),
(2,'Green Bay')

insert people_Choy values
(1,'Aaron Rodgers',2),
(2,'Russell Wilson',1),
(3,'Jody Nelson',2)

update people_Choy 
set City=(select Id from city_Choy where city='Green bay')
where City=(select id from city_Choy where City='Seattle')

delete city_Choy where city='seattle'

create view Packers_Choy as
select p.Name
from people_Choy p join city_Choy c on p.City=c.Id
where c.City='Green bay'

drop table if exists people_Choy,city_Choy
drop view if exists Packers_Choy

--10.
create proc sp_birthday_emplooyees_Choy @mth int
as
begin
	select LastName,FirstName 
	from Employees
	where month(BirthDate)=@mth
end
go

declare @birthday_employees_Choy table
	(LastName varchar(20), FirstName varchar(20))
insert into @birthday_employees_Choy
exec sp_birthday_emplooyees_Choy 2
select * from @birthday_employees_Choy

--11.
--Sub_query
create proc sp_Choy_1 as
select c.City
from Customers c join
(
select c.ContactName, od.ProductID
from customers c left join Orders o on c.CustomerID=o.CustomerID
join [Order Details] od on o.OrderID=od.OrderID
group by c.ContactName, od.ProductID
having count(*)<=1
) a on c.ContactName=a.ContactName
group by c.city
having count(*)>=2
go

--non_Sub_query

--12.
--use the 'Except' keyword to check 2 tables
--If the query returns any rows: They are not the same.
--If the query returns no rows: They are Identical.

--14.
declare @tmptable table
(FirstName varchar(20), LastName varchar(20), MiddleName varchar(20))
insert into @tmptable values
('John','Green',null),
('Mike','White','M')
select firstname+' '+lastname+isnull(' '+MiddleName+'.','') fullname from @tmptable

--15.
select top 1 student
from students
where sex='F'
order by marks desc

--16.
declare @tmptable table
(student varchar(20),marks int, sex char)
insert @tmptable values
('Li',90,'F'),
('Mi',95,'M'),
('Bob',80,'M'),
('Ci',70,'F')
select student,marks,sex from @tmptable
order by sex, 2 desc , 1

