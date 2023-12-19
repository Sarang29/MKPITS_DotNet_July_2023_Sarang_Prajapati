create table persons(Id int identity primary key,
First_Name varchar(20)not null,
Last_Name varchar(30) not null,
mobno bigint,
unique (mobno))

select * from persons

insert into persons values('Sarang','Prajapati',7378875024)
insert into persons values('Yash','Thakur',6451342858)
insert into persons values('David','Kothe',8451241635)
insert into persons values('Sujit','Khangar',7864555315)
insert into persons values('Chetan','Raut',8796541365)
