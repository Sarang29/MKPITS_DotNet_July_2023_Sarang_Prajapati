create table courses (
courseid int primary key,
coursename varchar(30),
fees int,
duration varchar(10))

insert into courses values(1,'Dotnet',10000,'40 Hours')
insert into courses values(2,'Java',20000,'60 Hours')
insert into courses values(3,'PHP',30000,'35 Hours')
insert into courses values(4,'Python',50000,'120 Hours')
insert into courses values(5,'Ruby',90000,'150 Hours')
insert into courses values(6,'Dotnet',50000,'120 Hours')
insert into courses values(7,'Dotnet',90000,'150 Hours')

create table student1 (
courseid int,
name varchar(20),
city varchar(20))

insert into student1 values(1,'Sarang','Nagpur')
insert into student1 values(6,'David','Pune')
insert into student1 values(7,'Lucky','Kolkata')

select * from courses
select * from student1

select name,city,courseid
from student1
where courseid in(
select courseid
from courses
where coursename = 'Dotnet')