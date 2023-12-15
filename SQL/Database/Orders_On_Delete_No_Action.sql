create table ordersnew (orderid int identity primary key,orderdate date,customerid int)

create table order_detailsnew (orderid int ,
productname varchar(20),
quantity int,
constraint fk4 foreign key(orderid)
references ordersnew(orderid))

insert into ordersnew values('2023-12-13',1)
insert into ordersnew values('2023-12-12',2)

insert into order_detailsnew values(1,'Mouse',5)
insert into order_detailsnew values(1,'Keyboard',6)
insert into order_detailsnew values(2,'Monitor',7)
insert into order_detailsnew values(2,'CPU',9)

select * from ordersnew
select * from order_detailsnew

drop table order_detailsnew

create table order_detailsnew(vendorid int identity primary key,
vendorname varchar(30),
groupid int not null,
constraint fk6 foreign key(groupid)
references ordersnew(orderid)on delete no action)

insert into order_detailsnew values('Sarang',1)
insert into order_detailsnew values('Akash',1)
insert into order_detailsnew values('Sujit',2)
insert into order_detailsnew values('Chetan',2)

select * from ordersnew
select * from order_detailsnew

delete from order_detailsnew where groupid=2

