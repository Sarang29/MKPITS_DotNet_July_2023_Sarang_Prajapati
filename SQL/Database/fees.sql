create table fees(rollno int,name varchar(20),course varchar(20),amount int,paiddate date)

select * from fees

insert into fees values (1,'Sarang','Dotnet',5000,'2023-01-23')
insert into fees values (2,'Aditya','Java',9000,'2023-02-15')
insert into fees values (3,'Jay','PHP',1000,'2023-03-1')
insert into fees values (4,'Raj','Dotnet',7000,'2023-04-5')
insert into fees values (5,'yash','Java',8000,'2023-02-19')
insert into fees values (6,'Rahul','Dotnet',6000,'2023-01-21')

select * from fees where paiddate between '2023-01-01' and '2023-02-30'

insert into fees values (7,'Akash','Dotnet',7000,'2023-11-5')
insert into fees values (8,'Chetan','Java',8000,'2023-11-19')
insert into fees values (9,'Kunal','Dotnet',6000,'2023-11-21')

select * from fees where paiddate between '2023-11-01' and '2023-11-30'