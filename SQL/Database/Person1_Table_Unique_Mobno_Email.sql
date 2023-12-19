create table person1(Id int identity primary key,
First_Name varchar(30) not null,
Last_Name varchar(30) not null,
mobno bigint,
email varchar(100),
unique(mobno,email))

select * from person1

insert into person1 values('Sarang','Prajapati',7378875014,'Sarangprajapti81@gmail.com')
insert into person1 values('David','Kothe',8569784265,'Davidkothe@gmail.com')
insert into person1 values('Sujit','Khangar',8756941264,'Sujitkhangar@gmail.com')
insert into person1 values('Chetan','Raut',9845327496,'Chetanraut@gmail.com')

alter table person1
add constraint unique_fname unique(First_Name)

sp_help person1

alter table person1
drop constraint unique_fname