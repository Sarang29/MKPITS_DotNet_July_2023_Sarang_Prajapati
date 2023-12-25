create table maxvalue (
id int primary key,
region varchar(30),
product varchar(30),
years int,
qty int,
price int)

insert into maxvalue values(1,'East','Computer',2020,120,40000)
insert into maxvalue values(2,'West','Computer',2020,450,35000)
insert into maxvalue values(3,'South','Hard Disk',2020,200,45000)
insert into maxvalue values(4,'North','Hard Disk',2020,150,6500)
insert into maxvalue values(5,'East','Computer',2021,435,8500)
insert into maxvalue values(6,'West','Hard Disk',2021,365,69000)
insert into maxvalue values(7,'North','Hard Disk',2021,600,80000)
insert into maxvalue values(8,'South','Pen Drive',2021,560,36000)
insert into maxvalue values(9,'West','Mouse',2019,750,75000)
insert into maxvalue values(10,'North','Pen Drive',2019,300,95000)
insert into maxvalue values(11,'East','Mouse',2019,150,47000)
insert into maxvalue values(12,'South','Pen Drive',2019,460,89000)

select * from maxvalue

select product,qty,price
from maxvalue
where price = (
select max(price) as "Maximum Quantity"
from maxvalue)