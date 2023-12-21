create table student(id int primary key identity,
admission_no varchar(20)not null,
first_name varchar(20)not null,
last_name varchar(20)not null,
agr int,
city varchar(20)not null)

select * from student

insert into student values(8001,'Sarang','Prajapati',22,'Paris')
insert into student values(8002,'Akash','Gautam',21,'London')
insert into student values(8003,'Lucky','Tambe',20,'Uk')
insert into student values(8004,'David','Kothe',25,'West Indies')
insert into student values(8005,'Sujit','Khangar',19,'Europe')

create table fee(admission_no varchar(20)not null,
course varchar(20)not null,
amount_paid int)

insert into fee values(8002,'Dotnet',60000)
insert into fee values(8004,'Java',80000)
insert into fee values(8001,'PHP',50000)
insert into fee values(8005,'Python',100000)

select * from fee

select student.admission_no,student.first_name,student.last_name,fee.course,fee.amount_paid
from student
inner join fee
on student.admission_no=fee.admission_no;