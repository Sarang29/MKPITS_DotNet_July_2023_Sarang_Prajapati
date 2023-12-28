create table orders(
orderid int,
orderdate date,
custid int,
productid int,
rate int,
qty int,
city varchar(max),
state varchar(max))

insert into orders values(1,'2023-12-12',1,1,300,4,'Nagpur','Maharashtra')
insert into orders values(1,'2023-12-11',1,1,400,2,'Nagpur','Maharashtra')
insert into orders values(1,'2023-12-10',1,1,100,8,'Nagpur','Maharashtra')
insert into orders values(2,'2023-11-10',2,2,600,4,'Nagpur','Maharashtra')
insert into orders values(2,'2023-11-09',2,2,750,9,'Nagpur','Maharashtra')


select * from orders