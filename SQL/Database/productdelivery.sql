create table productdelivery (id int,name varchar(20),quantity int,dates date)

select * from productdelivery

insert into productdelivery values(1,'Mouse',50,'2023-12-12')
insert into productdelivery values(2,'ROM',20,'2023-12-02')
insert into productdelivery values(3,'Monitor',30,'2023-06-12')
insert into productdelivery values(4,'Keyboard',4,'2023-11-15')
insert into productdelivery values(5,'Mouse',12,'2023-11-29')
insert into productdelivery values(6,'RAM',40,'2023-11-25')

select * from productdelivery where dates between '2023-12-01' and '2023-12-12'