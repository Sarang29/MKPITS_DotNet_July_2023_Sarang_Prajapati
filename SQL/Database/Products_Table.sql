create table products(Product_Id int identity primary key,
Product_Name varchar(20) not null,
Unit_Price dec(10,2) check (Unit_Price > 0),
Discounted_Price dec(10,2) check (Discounted_Price > 0),
check (Discounted_Price < Unit_Price))

select * from products

insert into products values('Pencil',10,8)
insert into products values('Pen',8,7)
insert into products values('Eraser',5,null)
insert into products values('Sharpner',6,5.5)
insert into products values('Divider',null,null)
