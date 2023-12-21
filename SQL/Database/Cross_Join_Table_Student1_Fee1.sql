create table student1(
admission_no varchar(20) not null,
first_name varchar(20) not null,
city varchar(10)not null)

insert into student1 values(1001,'Sarang','London')
insert into student1 values(1002,'Akash','Dubai')
insert into student1 values(1003,'David','Africa')
insert into student1 values(1004,'Sujit','Mauritius')
insert into student1 values(1005,'Chetan','Goa')

create table fee1 (
admission_no varchar(10) not null,
course varchar(20) not null,
amount_paid int not null)

insert into fee1 values(1002,'Dotnet',75000)
insert into fee1 values(1004,'Java',85000)
insert into fee1 values(1005,'PHP',50000)
insert into fee1 values(1001,'Python',150000)

select * from student1
select * from fee1

select student1.admission_no,student1.first_name,student1.city,fee1.course,fee1.amount_paid
from student1
cross join fee1
where student1.admission_no=fee1.admission_no;