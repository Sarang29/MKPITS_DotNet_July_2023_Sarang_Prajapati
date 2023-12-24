create table customer (
cust_id varchar(20) not null,
cust_name varchar(20) not null,
mob_no bigint not null)

insert into customer values(1001,'Sarang',7378875025)
insert into customer values(1002,'David',6453136454)
insert into customer values(1003,'Yash',9785416345)
insert into customer values(1004,'Kunal',7965246515)

create table orders(
order_id int primary key identity,
cust_id varchar(20) not null,
product_name varchar(20)not null,
price varchar(20)not null,
quantity varchar(20) not null)

insert into orders values(1002,'Mouse',500,5)
insert into orders values(1004,'Keyboard',600,2)
insert into orders values(1003,'CPU',800,6)

select * from customer
select * from orders

select customer.cust_id,customer.cust_name,customer.mob_no,orders.product_name,orders.price
from customer
full join orders
on customer.cust_id=orders.cust_id;