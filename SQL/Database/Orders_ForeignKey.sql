create table orders (orderid int identity primary key,orderdate date)

create table order_details (productid int,
productname varchar(30),
orderid int not null, 
constraint fk5 foreign key(orderid)
references orders(orderid))

select * from orders
select * from order_details

insert into orders values('2023-12-13')
insert into orders values('2023-12-12')

insert into order_details values(1,'Oven',1)
insert into order_details values(2,'Tv',1)
insert into order_details values(3,'Fridge',2)
insert into order_details values(4,'Ac',2)

delete from order_details where orderid=1
delete from orders where orderid=1

