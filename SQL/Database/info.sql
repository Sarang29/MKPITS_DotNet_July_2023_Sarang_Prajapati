create table info(id int,name varchar(20),city varchar(20))

select * from info

insert into info values(1,'Sarang','Nagpur')
insert into info values(2,'Akash','Pune')
insert into info values(3,'Sujit','Bhopal')
insert into info values(4,'Chetan','Bhopal')
insert into info values(5,'David','Pune')
insert into info values(6,'Lucky','Nagpur')

select distinct name from info

insert into info values(5,'David','Pune')
insert into info values(6,'Lucky','Nagpur')