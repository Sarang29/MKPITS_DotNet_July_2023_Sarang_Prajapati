create table fees(
rollno int primary key identity,
fees_date date,
amount int
)

insert into fees values('2023-12-01',15000)
insert into fees values('2023-12-05',17000)
insert into fees values('2023-12-10',11000)
insert into fees values('2023-12-15',9000)
insert into fees values('2023-12-17',20000)
insert into fees values('2023-12-20',16000)

select * from fees

select rollno,sum(amount)
from fees
group by rollno

