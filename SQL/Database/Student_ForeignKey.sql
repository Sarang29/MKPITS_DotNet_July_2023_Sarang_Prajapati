create table student (rollno int identity primary key,name varchar(20),address varchar(30))

create table fees (feesid int primary key,
rollno int not null,
amount int,
paydate date,
constraint fk7 foreign key(rollno)
references student (rollno))

select * from student
select * from fees

insert into student values('Sarang','Nagpur')
insert into student values('Akash','Akola')
insert into student values('Lucky','Pune')

insert into fees values(1,1,5000,'2023-12-13')
insert into fees values(2,1,5000,'2023-12-16')
insert into fees values(3,2,4000,'2023-12-18')
insert into fees values(4,2,6000,'2023-12-20')
insert into fees values(5,3,8000,'2023-12-22')
insert into fees values(6,3,2000,'2023-12-26')

select * from student
select * from fees

