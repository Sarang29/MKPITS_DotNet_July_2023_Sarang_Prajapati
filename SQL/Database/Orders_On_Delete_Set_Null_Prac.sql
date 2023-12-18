drop table order_detailsnew

create table order_detailsnew(vendorid int identity primary key,
vendorname varchar(30),
groupid int ,
constraint fk6 foreign key(groupid)
references ordersnew(orderid)on delete set null)

insert into ordersnew values('2023-12-14',4)

insert into order_detailsnew values('Sarang',2)
insert into order_detailsnew values('Akash',2)
insert into order_detailsnew values('Sujit',4)
insert into order_detailsnew values('Chetan',4)

select * from ordersnew
select * from order_detailsnew

delete from ordersnew where orderid=2
