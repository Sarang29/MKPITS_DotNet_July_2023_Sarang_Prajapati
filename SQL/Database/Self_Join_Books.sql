drop table books

create table books(
id int primary key identity,
title varchar(100) not null,
author varchar(20) not null)

insert into books values('Fault in our Stars','David')
insert into books values('The Untold Story','Alex')
insert into books values('The Railway Man','David')
insert into books values('Shining Stars','Alex')
insert into books values('Adhuri Kahani','Chetan Bhagat')

select * from books

select b2.title,b2.author
from books b1,books b2
where b1.id <> b2.id
and b1.author = b2.author;