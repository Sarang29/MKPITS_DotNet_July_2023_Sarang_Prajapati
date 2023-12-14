create table product (id int, name varchar(20),years int,price int)

select * from product

insert into product values(1,'Apple',2023,500)
insert into product values(2,'Kiwi',2023,900)
insert into product values(3,'Lichi',2020,700)
insert into product values(4,'Grapes',2021,100)
insert into product values(5,'Mango',2021,200)
insert into product values(6,'Chiku',2020,500)

select id,name,years,price from product where price IN (500,700)

select * from product where name like '%ch%'