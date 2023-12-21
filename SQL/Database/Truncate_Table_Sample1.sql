create table sample1(id int primary key identity,pname varchar(20),price varchar(10),quantity varchar(10))

insert into sample1 values('mouse',200,2)
insert into sample1 values('keyboard',300,3)
insert into sample1 values('monitor',150,5)
insert into sample1 values('CPU',900,2)

select * from sample1

delete from sample1
where pname='mouse'

insert into sample1 values('mouse',500,9)

truncate table sample1