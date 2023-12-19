create table product3 (Product_Id int primary key,
Product_Name varchar(20)not null,
Unit_Price dec(10,2),
Discounted_Price dec(10,2),
check (Unit_Price > 0),
check (Discounted_Price > 0),
check (Discounted_Price < Unit_Price))

select * from product3

sp_help product3

alter table product3
drop constraint CK__product3__3E1D39E1

alter table product3
add constraint ck1 check(Discounted_Price > 0 AND Discounted_Price < Unit_Price)

alter table product3
drop constraint CK__product3__Discou__3D2915A8

insert into product3 values (1,'Mouse',220,200)
insert into product3 values (2,'Keyboard',300,280)
insert into product3 values (3,'Monitor',600,550)
insert into product3 values (4,'CPU',900,800)
insert into product3 values (5,'',null,null)

select * from product3

delete from product3 where Product_Id=5