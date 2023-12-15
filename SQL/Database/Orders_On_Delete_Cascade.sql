drop table order_detailsnew

create table order_detailsnew(vendorid int identity primary key,
vendorname varchar(30),
groupid int not null,
constraint fk6 foreign key(groupid)
references ordersnew(orderid)on delete cascade)

insert into ordersnew values('2023-12-14',3)

insert into order_detailsnew values('Sarang',1)
insert into order_detailsnew values('Akash',1)
insert into order_detailsnew values('Sujit',3)
insert into order_detailsnew values('Chetan',3)

select * from ordersnew
select * from order_detailsnew

delete from ordersnew where orderid=1
delete from ordersnew where orderid=3