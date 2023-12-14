create table orderdelivery(orderno int,purchaseamt float,orderdate date,cust_id int,sales_id int)

select * from orderdelivery

insert into orderdelivery values(7001,150.51,'2023-11-08',3004,5002)
insert into orderdelivery values(7002,200.79,'2023-11-02',3005,5003)
insert into orderdelivery values(7003,158.87,'2023-11-03',3006,5002)
insert into orderdelivery values(7004,250.89,'2023-12-12',3007,5005)
insert into orderdelivery values(7005,506.59,'2023-12-08',3008,5006)
insert into orderdelivery values(7006,199.35,'2023-12-06',3009,5007)
insert into orderdelivery values(7007,287.54,'2023-12-05',3001,5002)
insert into orderdelivery values(7008,987.65,'2023-11-05',3002,5009)

select orderno,orderdate,purchaseamt from orderdelivery where sales_id=5002

DELETE FROM orderdelivery where sales_id=5006
 