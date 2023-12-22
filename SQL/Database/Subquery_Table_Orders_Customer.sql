create table orders (
order_id int primary key,
customer_id int ,
order_status varchar(20),
order_date date,
requrired_date date,
shipped_date date,
store_id int,
staff_id int)

create table customer(
customer_id int primary key,
first_name varchar(20),
last_name varchar(20),
phone bigint,
email varchar(50),
street varchar(100),
city varchar(50),
state varchar(100),
zipcode int)

select * from orders
select * from customer

insert into orders values(1,1,'Shipped','2023-12-04','2023-12-05','2023-12-06',1,1)
insert into orders values(2,2,'Dispached','2023-11-04','2023-11-05','2023-11-06',2,2)
insert into orders values(3,3,'Packed','2023-12-10','2023-12-11','2023-12-12',3,3)
insert into orders values(4,4,'Delivered','2023-10-09','2023-10-10','2023-10-11',4,4)

insert into customer values(1,'Sarang','Prajapati',7378874024,'Sarangprajapati81@gmail.com','Kamal Chowk','Nagpur','Maharashtra',440017)
insert into customer values(2,'Lucky','Tambe',6485751533,'Luckytambe@gmail.com','Kamal Chowk','Nagpur','Maharashtra',440017)
insert into customer values(3,'Sujit','Khangar',6585741533,'Sujitkhangar@gmail.com','Nandanvan','Nagpur','Maharashtra',440111)
select * from customer
select * from orders


select order_id,order_date,order_status,customer_id
from orders
where customer_id in(
select customer_id
from customer
where street = 'Kamal Chowk')