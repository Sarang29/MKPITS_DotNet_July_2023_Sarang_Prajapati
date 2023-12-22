create table student(
rno int primary key,
name varchar(20),
email varchar(100),
city varchar(20),
courseid int)

select * from student
insert into student values(1,'Sarang','Sarangprajapati@gmail.com','Nagpur',123)
insert into student values(2,'Akash','Akashgautam@gmail.com','Chandrapur',456)
insert into student values(3,'David','Davidkothe@gmail.com','Tumsar',789)
insert into student values(4,'Chetan','Chetanraut@gmail.com','Amravati',987)
insert into student values(5,'Sujit','Sujitkhangar@gmail.com','Bhandara',654)
insert into student values(6,'Yash','Yashjaiswal@gmail.com','Nagpur',852)

select * from student
select * from fee

create table fee(
feesid int primary key,
rno int,
feesdate date,
amount int,
courseid int)

insert into fee values(1,1,'2023-12-01',15000,11)
insert into fee values(2,2,'2023-12-15',20000,22)
insert into fee values(3,3,'2023-12-25',45000,33)
insert into fee values(4,4,'2023-12-14',65000,11)
insert into fee values(5,5,'2023-12-19',90000,22)
insert into fee values(6,6,'2023-12-29',50000,33)

truncate table fee

select feesid,amount,courseid,rno
from fee
where rno in(
select rno
from student
where city='Nagpur')