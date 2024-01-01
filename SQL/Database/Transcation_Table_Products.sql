create table products(product_id int primary key,
product_name varchar(40),
price int,
quantity int
)

insert into products values(1,'Mouse',200,5),
(2,'Keyboard',300,9),
(3,'Monitor',8000,4),
(4,'CPU',9100,2),
(5,'Generator',5000,1)

select * from products

begin transaction

insert into products values(6,'Battery',4000,7)
update products set price = 7000 where product_id=3

commit

select * from products

begin transaction

update products set price=350 where product_id=2
delete from products where product_id = 3	

select * from products

rollback transaction