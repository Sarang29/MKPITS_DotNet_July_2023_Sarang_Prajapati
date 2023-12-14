CREATE DATABASE practice

create table salesman(id int,name varchar(20),city varchar(20),commission float)

select * from salesman

insert into salesman values(5001,'Sarang','Nagpur',0.15)
insert into salesman values(5002,'Akash','Delhi',0.25)
insert into salesman values(5003,'Lucky','Kolkata',0.35)
insert into salesman values(5004,'David','Nagpur',0.45)
insert into salesman values(5005,'Yash','Mumbai',0.55)
insert into salesman values(5006,'Sahil','Pune',0.65)

create table salesman1(id int,name varchar(20),city varchar(20),commission float)

select * from salesman1

insert into salesman1 values(5001,'Sarang','Nagpur',0.15)
insert into salesman1 values(5002,'Akash','Delhi',0.25)
insert into salesman1 values(5003,'Lucky','Kolkata',0.35)
insert into salesman1 values(5004,'David','Nagpur',0.45)
insert into salesman1 values(5005,'Yash','Mumbai',0.55)
insert into salesman1 values(5006,'Sahil','Pune',0.65)

insert into salesman1 values(5007,'Raj','Pune',280.25)

select name,commission from salesman1 