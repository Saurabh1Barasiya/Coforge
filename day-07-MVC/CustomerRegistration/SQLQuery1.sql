create database Registration
use Registration
create table CustomerRes(
Cid int identity,
Cname nvarchar(20),
Cage nvarchar(10),
Ccity nvarchar(20)
);

select * from CustomerRes;

insert into CustomerRes values('Amit nag','22','Harrai');