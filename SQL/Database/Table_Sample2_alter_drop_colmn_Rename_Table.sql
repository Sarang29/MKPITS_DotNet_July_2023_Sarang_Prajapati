create table sample2 (id int identity primary key,pname varchar(20),price int)

insert into sample2 values('mouse',200)
insert into sample2 values('keyboard',300)
insert into sample2 values('cpu',900)
insert into sample2 values('monitor',1000)

select * from sample2

alter table sample2
add quantity int

alter table sample2
alter column price dec(10,2)

alter table sample2
drop column quantity

select * from sample2

sp_rename 'sample2','sample3'

select * from sample3

Exec sp_rename 'sample3.id','sr no','column'