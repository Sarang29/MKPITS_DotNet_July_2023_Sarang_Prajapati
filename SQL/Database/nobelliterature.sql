create table nobelliterature(years int,subject varchar(20),winner varchar(20),country varchar(20),category varchar(20))

select * from nobelliterature

insert into nobelliterature values(1970,'Physics','Hannes Alfven','Sweden','Scientist')
insert into nobelliterature values(1970,'Physics','Louis Neel','France','Scientist')
insert into nobelliterature values(1970,'Chemistry','Luis Federico Leloir','France','Scientist')
insert into nobelliterature values(1970,'Physics','Ulf von Euler','Sweden','Scientist')
insert into nobelliterature values(1970,'Physics','Bernard Katz','Germany','Scientist')
insert into nobelliterature values(1971,'Physics','Aleksandr','Russia','Linguist')
insert into nobelliterature values(1970,'Economics','Paul Samuelson','USA','Scientist')

select winner from nobelliterature where years=1971 