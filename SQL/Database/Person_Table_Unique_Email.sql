create table person(Id int identity primary key,
First_Name varchar(30)not null,
Last_Name varchar(30)not null,
Email varchar(80) unique)

select * from person

insert into person values('Sarang','Prajapati','Sarangprajapati81@gmail.com')
insert into person values('David','Kothe','Davidkothe@gmail.com')
insert into person values('Lucky','Tambe','Luckytambe@gmail.com')
insert into person values('Akash','Gautam','Akashgautam@gmail.com')
insert into person values('Sujit','Khangar','Sujitkhangar@gmail.com')
insert into person values('Chetan','Raut','Chetanraut@gmail.com')
insert into person values('Yash','Jaiswal','Yashjaiswal@gmail.com')