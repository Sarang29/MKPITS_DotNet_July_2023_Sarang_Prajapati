create table employee (
emp_id int primary key,
emp_name varchar(max),
emp_mob bigint,
emp_state varchar(max))

insert into employee values(1,'Akash',7378875024,'Maharashtra')
insert into employee values(2,'Yash',976319863,'Up')
insert into employee values(3,'Sujit',9845631973,'Mp')
insert into employee values(4,'Chetan',8976321594,'Goa')
insert into employee values(5,'Lucky',8975246319,'Assam')

select * from employee

create table employee1 (
mob varchar(max),
emp_id int,
constraint fk6 foreign key(emp_id)
references employee(emp_id))

insert into employee1 values(8546365497,1),
(9654789632,1),
(7896541236,2),
(8547896123,2),
(7458962159,3),
(7458916798,3),
(9789465496,4),
(8965426197,5);

select * from employee
select * from employee1