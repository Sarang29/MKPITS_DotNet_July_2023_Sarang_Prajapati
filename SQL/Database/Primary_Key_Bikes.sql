create table bikes(
id int primary key identity,
name varchar(20) not null,
colour varchar(20)not null,
location varchar(20)not null)

insert into bikes values('Harley Davidson','Black','Raipur')
insert into bikes values('R15 V3','Blue','Delhi')
insert into bikes values('MT-15','Green','Pune')
insert into bikes values('Tiger Triumph','Black','Nagpur')

select * from bikes