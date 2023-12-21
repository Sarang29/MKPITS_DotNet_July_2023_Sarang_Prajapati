create table product(product_id int primary key,roduct_name varchar(20),price int,quantity int)

insert into product values (1,'Mouse',500,4)
insert into product values (2,'Keyboard',200,2)
insert into product values (3,'Monitor',900,5)
insert into product values (4,'RAM',400,3)

select * from product

update product set price = 10000
where roduct_name = 'Monitor'

update product set quantity=10
where roduct_name = 'RAM'

delete from product
where roduct_name='mouse'


