use Registration;

create table Student(
Sid int  identity,
SFname nvarchar(20),
SLname nvarchar(20),
Scity nvarchar(20)
);
insert into Student values('Anu','pawar','harrai')
insert into Student values('rani','pawar','harrai')
insert into Student values('jani','pawar','harrai')
insert into Student values('tanu','pawar','harrai')
insert into Student values('panu','pawar','harrai')

select  * from Student;