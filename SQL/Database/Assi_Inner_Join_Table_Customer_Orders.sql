create table customer(
cust_id int primary key,
cust_name varchar(20)not null,
mob_no bigint)

insert into customer values(1001,'Akash',7378875014)
insert into customer values(1002,'Sujit',8547922499)
insert into customer values(1003,'Chetan',5367458895)
insert into customer values(1004,'Lucky',9775225455)
insert into customer values(1005,'David',9769425645)

select * from customer

create table orders (
order_id int primary key identity,
orderdate date,
cust_id int not null,
product_name varchar(20),
quantity int not null,
rate int not null)

insert into orders values('2023-12-01',1002,'Mouse',5,250)
insert into orders values('2023-12-03',1005,'Keyboard',9,400)
insert into orders values('2023-12-08',1001,'Monitor',3,1500)
insert into orders values('2023-12-15',1003,'CPU',12,2000)

select * from customer
select * from orders

select customer.cust_name,customer.mob_no,orders.product_name,orders.quantity,orders.rate
from customer 
inner join orders
on customer.cust_id=orders.cust_id;