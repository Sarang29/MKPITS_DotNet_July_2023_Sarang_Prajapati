create table emp(
id int primary key identity,
name varchar(30),
occupation varchar(30),
working_date date,
working_hours int,
salary int)

insert into emp values('David','HR','2023-01-02',8,60000)
insert into emp values('Akash','Clerk','2023-01-06',9,54000)
insert into emp values('Lucky','Peon','2023-01-12',12,30000)
insert into emp values('Sujit','Bell Boy','2023-01-15',7,15000)
insert into emp values('Chetan','Water Boy','2023-01-17',13,10000)
insert into emp values('Ashwin','Manager','2023-01-19',8,80000)
insert into emp values('Kunal','Trainee','2023-01-20',9,19000)
insert into emp values('Yash','Guard','2023-01-24',10,25000)

select * from emp

select avg(working_hours) as "Average Working Hours"
from emp
where occupation='Bell Boy'