create database AdvancedDb
use AdvancedDb
create table Employees
(EmployeeId int primary key,
FirsdtName nvarchar(50),
LastName nvarchar(50),
BirthDate Date,
Salary float)
insert into Employees values (1,'Sravs','ch','12/12/2000',45000.78)
insert into Employees values (2,'Swathi','ch','02/05/2001',54000.78)
insert into Employees values (3,'Venky','ch','03/03/1997',34000.78)
insert into Employees values (4,'Swapna','ch','04/04/1997',44500.78)
insert into Employees values (5,'sreekanth','ch','06/06/1994',23000.78)
select * from Employees

create table Products
(
ProductId int primary key,
ProductName nvarchar(50),
PDescription nvarchar(50),
Price Money,
RealeaseDate DateTime)
insert into products values (12,'rice','this is used in homes',$4500,'03/23/2023')
insert into products values (13,'fruits','this is used in homes',$4500,'03/23/2023')
insert into products values (14,'BANDS','this is used in homes',$4500,'03/23/2023')
insert into products values (15,'Roaps','this is used in homes',$4500,'03/23/2023')
insert into products values (16,'Soaps','this is used in hotel',$800,'03/12/2023')
select * from Products

create table Orders
(OrderId int primary key,
OrderDate datetime,
OrderQuantity smallint,
Discount float,
IsShipped bit)
insert into Orders values (111,'03/08/2022',3,50.50,'false')
insert into Orders values (112,'01/18/2017',3,23.50,'true')
insert into Orders values (113,'02/12/2018',4,50,'true')
insert into Orders values (114,'05/13/2019',6,45.50,'true')
insert into Orders values (115,'04/06/2020',7,36.50,'false')
select * from Orders
