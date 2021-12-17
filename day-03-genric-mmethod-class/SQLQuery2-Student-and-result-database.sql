create database ExerciseDb;
use ExerciseDb;
create table Student(
Sid int primary key,
Sname nvarchar(20),
Semail nvarchar(20),
Scontact Nvarchar(20)
);

--drop table Result;

create table Result( 
Sid int primary key foreign key references Student (Sid),
Sresult Nvarchar(10),
);

Insert into Student values(1,'Sam','sam@gmail.com','1111111111');
Insert into Student values(2,'Pam','pam@gmail.com','1111111111');
Insert into Student values(3,'jam','jam@gmail.com','1111111111');
Insert into Student values(4,'Ram','ram@gmail.com','1111111111');
Insert into Student values(5,'Tam','tam@gmail.com','1111111111');


insert into Result values(1,'paas');
insert into Result values(2,'paas');
insert into Result values(3,'paas');
insert into Result values(4,'fial');
insert into Result values(5,'fail');

select * from Student;
select * from Result;