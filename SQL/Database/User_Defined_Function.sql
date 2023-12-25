create table emp(
id int primary key identity,
name varchar(30),
mob bigint,
email varchar(50),
dept varchar(30),
city varchar(30),
salary int)

insert into emp values('David',7896541236,'Davidkothe@gmail.com','HR','Kamthi',60000)
insert into emp values('Akash',8541239654,'Akashgautam@gmail.com','Clerk','Wanadongri',54000)
insert into emp values('Lucky',9654123658,'Luckyambe@gmail.com','Peon','Pune',30000)
insert into emp values('Sujit',7963245695,'Sujitbahngar@gmail.com','Bell Boy','Raipur',15000)
insert into emp values('Chetan',9265349731,'Chutandaut@gmail.com','Water Boy','Bhandara',10000)
insert into emp values('Ashwin',6743364451,'Ashwindkoche@gmail.com','Manager','Nagpur',80000)
insert into emp values('Kunal',8763984219,'Kunaldon@gmail.com','Trainee','Kolhapur',19000)
insert into emp values('Yash',7921653971,'Yashjaiswal@gmail.com','Guard','Nashik',25000)

select * from emp

create function f1()
returns table 
as
return (select * from emp)

select * from f1()