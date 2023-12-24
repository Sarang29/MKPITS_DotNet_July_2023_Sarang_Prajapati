drop table student

create table student (
student_id int primary key identity,
first_name varchar(20)not null,
last_name varchar(20)not null,
city varchar(20) not null)

insert into student values('Sarang','Prajapati','Goa'),
('Akash','Gautam','Nagpur'),
('David','Kothe','Pune'),
('Pranay','Guhe','Kolkata')
insert into student values('Kunal','Kumar','Nagpur')

select * from student

select s1.first_name,s2.last_name,s2.city
from student s1, student s2
where s1.student_id <> s2.student_id
and s1.city=s2.city
order by city;
