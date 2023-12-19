create table product (Product_id int identity primary key,
Product_Name varchar(30) not null,
unit_price dec(10,2) check (unit_price > 0))

select * from product

insert into product values('Mouse',500)
insert into product values('Keyboard',400)
insert into product values('Monitor',900)
insert into product values('CPU',600)
insert into product values('RAM',1000)
insert into product values('ROM',1200)
insert into product values('Battery',1500)