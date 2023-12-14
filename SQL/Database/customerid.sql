create table customerid (cust_id int,cust_name varchar(20),city varchar(20),grade int,salesman_id int)

select * from customerid

insert into customerid values(4001,'Akash','Paris',200,5001)
insert into customerid values(4002,'Yash','Canada',500,5002)
insert into customerid values(4003,'Sujit','Dubai',300,5003)
insert into customerid values(4004,'Chetan','Europe',200,5004)
insert into customerid values(4005,'Sujal','Rome',200,5005)
insert into customerid values(4006,'Pranay','USA',900,5006)
insert into customerid values(4007,'Harsh','London',800,5007)

select cust_id,cust_name,city,grade,salesman_id from customerid where grade=200