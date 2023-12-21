create table customer1 (
cust_id varchar(20) not null,
cust_name varchar(20) not null,
mob_no bigint not null)

insert into customer1 values(1001,'Sarang',7378875025)
insert into customer1 values(1002,'David',6453136454)
insert into customer1 values(1003,'Yash',9785416345)
insert into customer1 values(1004,'Kunal',7965246515)

create table orders1(
order_id int primary key identity,
cust_id varchar(20) not null,
product_name varchar(20)not null,
price varchar(20)not null,
quantity varchar(20) not null)

insert into orders1 values(1002,'Mouse',500,5)
insert into orders1 values(1004,'Keyboard',600,2)

select * from customer1
select * from orders1

select customer1.cust_id,customer1.cust_name,customer1.mob_no,orders1.product_name,orders1.price
from customer1
left join orders1
on customer1.cust_id=orders1.cust_id;