create table order1 (orderno int,purchaseamt float,orderdate date, custid int,salesid int)

select * from order1

insert into order1 values(7001,150.51,'2023-11-08',3004,5002)
insert into order1 values(7002,200.79,'2023-11-02',3005,5003)
insert into order1 values(7003,158.87,'2023-11-03',3006,5004)
insert into order1 values(7004,250.89,'2023-12-12',3007,5005)
insert into order1 values(7005,506.59,'2023-12-08',3008,5006)
insert into order1 values(7006,199.35,'2023-12-06',3009,5007)
insert into order1 values(7007,287.54,'2023-12-05',3001,5008)
insert into order1 values(7008,987.65,'2023-11-05',3002,5009)
 
insert into order1 values(7011,650.51,'2023-11-22',3014,5002)
insert into order1 values(7012,500.79,'2023-11-25',3015,5003)
insert into order1 values(7013,458.87,'2023-11-14',3016,5004)
insert into order1 values(7014,350.89,'2023-12-02',3017,5005)

select  DISTINCT salesid from order1
