CREATE DATABASE NEWDATA

create table students (rollno int,first_name varchar(20),last_name varchar(20),course varchar(20),city varchar(20))

select * from students

insert into students values(1,'Sarang','Prajapati','Dotnet','Nagpur')
insert into students values(2,'Lucky','Tambe','Java','Pune')
insert into students values(3,'Akash','Gautam','Dotnet','Nagpur')
insert into students values(4,'David','Kothe','Java','Pune')
insert into students values(5,'Chetan','Raut','Dotnet','Nagpur')
insert into students values(6,'Sujit','Khangar','Java','Pune')

select first_name,last_name from students order by first_name asc

select first_name,last_name from students order by first_name,last_name


create table customer(first_name varchar(20),last_name varchar(20),city varchar(20))

select * from customer

insert into customer values('Sarang','Prajapati','Nagpur')
insert into customer values('Akash','Gautam','Mumbai')
insert into customer values('Lucky','Tambe','Pune')
insert into customer values('David','Kothe','Pune')
insert into customer values('Chetan','Raut','Pune')
insert into customer values('Sujit','bhau','Nagpur')
insert into customer values('Sahil','More','Nagpur')
insert into customer values('Sarvesh','Bankar','Mumbai')

select city,first_name from customer order by city,first_name desc

select * from students

select first_name from students order by LEN(first_name)desc; 

SELECT TOP 2 first_name,last_name,city from students order by city

insert into students values(7,'Kunal','Yadav','PHP','Akola')

create table product1(id int,
customer_name varchar(20),
product_name varchar(20),
city varchar(20));

insert into product1(id,customer_name,product_name,city)
values(1,'RAM','Sarang','Nagpur'),
(2,'ROM','Akash','Pune')

select * from product1
