create table student2(
admission_no varchar(20)not null,
first_name varchar(20) not null,
last_name varchar(20) not null,
city varchar(20) not null)

insert into student2 values(2001,'Sarang','Prajapati','Nagpur')
insert into student2 values(2002,'Akash','Gautam,','Wanadongri')
insert into student2 values(2003,'David','Kothe','Chapru')
insert into student2 values(2004,'Sujit','Khangar','Vaishali Ngr')

create table fee2(
admission_no varchar(20) not null,
course varchar(20)not null,
amount_paid varchar(20) not null)

insert into fee2 values(2003,'Dotnet',75000)
insert into fee2 values(2001,'PHP',85000)

select * from student2
select * from fee2

select student2.admission_no,student2.first_name,fee2.course,fee2.amount_paid
from student2
left outer join fee2
on student2.admission_no=fee2.admission_no;