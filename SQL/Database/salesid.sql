create table salesid (id int,name varchar(20),city varchar(20),commission float)	

select * from salesid

insert into salesid values(8001,'Sarang','Nagpur',0.15)
insert into salesid values(8002,'Akash','Raipur',0.25)
insert into salesid values(8003,'Sujit','Bhopal',0.35)
insert into salesid values(8004,'Lucky','Pune',0.45)
insert into salesid values(8005,'Chetan','Delhi',0.55)
insert into salesid values(8006,'Yash','Mumbai',0.65)
insert into salesid values(8007,'Sahil','Bihar',0.75)
insert into salesid values(8008,'Sarvesh','Solapur',0.85)

insert into salesid values(8005,'Kunal','USA',0.55)
insert into salesid values(8006,'Mayur','Paris',0.65)
insert into salesid values(8007,'Aditya','London',0.75)
insert into salesid values(8008,'Sujal','Paris',0.85)

select name,city from salesid where city='Paris'