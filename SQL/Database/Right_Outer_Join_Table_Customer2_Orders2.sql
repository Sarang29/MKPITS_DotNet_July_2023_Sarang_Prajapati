create table customer2 (
cust_id varchar(20) not null,
cust_name varchar(20) not null,
mob_no bigint not null)

insert into customer2 values(1001,'Sarang',7378875025)
insert into customer2 values(1002,'David',6453136454)
insert into customer2 values(1003,'Yash',9785416345)
insert into customer2 values(1004,'Kunal',7965246515)

create table orders2(
order_id int primary key identity,
cust_id varchar(20) not null,
product_name varchar(20)not null,
price varchar(20)not null,
quantity varchar(20) not null)

insert into orders2 values(1002,'Mouse',500,5)
insert into orders2 values(1004,'Keyboard',600,2)

select * from customer2
select * from orders2

select customer2.cust_id,customer2.cust_name,customer2.mob_no,orders2.product_name,orders2.price
from customer2
right join orders2
on customer2.cust_id=orders2.cust_id;