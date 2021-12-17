create database day19db;
use day19db;

create  table Products(
Pid int primary key identity,
Pname nvarchar(50) not null,
PPrice float,
PMfd datetime,
PExd datetime
);

Insert into Products values('Harbar-shampoo',200.00,'12/12/2020','12/12/2022');
Insert into Products values('Rexotone',1000.20,'12/12/2020','12/12/2022');
Insert into Products values('Neem sop',500.20,'12/12/2020','12/12/2022');
Insert into Products values('Alovera sop',400.20,'12/12/2020','12/12/2022');
Insert into Products values('dal',300.20,'12/12/2020','12/12/2022');

select * from Products;