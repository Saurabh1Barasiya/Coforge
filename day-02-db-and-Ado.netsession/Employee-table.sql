create database day01;
use day01;
create table Emp(
Eid int primary key,
Ename nvarchar(20),
Edeig nvarchar(20),
Esalary float,
Doj Datetime
);

insert into Emp values(1,'Sam','H-R',40000,'12/24/2021'); -- mm/dd/yyyy
insert into Emp values(2,'Ram','MANAGER',20000,'12/24/2021');
insert into Emp values(3,'Pam','DEVELOPER',60000,'12/24/2021');
insert into Emp values(4,'Mam','DEVELOPER',60000,'12/24/2021');
insert into Emp values(5,'Jam','DEVELOPER',60000,'12/24/2021');
insert into Emp values(6,'Sam','H-R',40000,'12/24/2021');
insert into Emp values(7,'Sam','H-R',40000,'12/24/2021');
insert into Emp values(8,'Tam','MANAGER',20000,'12/24/2021');

SELECT * FROM Emp;

update  Emp  set Edeig = 'human-r' where Edeig  = 'H-R';