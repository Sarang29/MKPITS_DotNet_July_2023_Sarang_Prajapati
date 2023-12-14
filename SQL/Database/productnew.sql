SELECT TOP (1000) [id]
      ,[name]
      ,[price]
      ,[quantity]
  FROM [master].[dbo].[productnew]
  select * from productnew

  insert into productnew values(1,'Mouse',300,10)
insert into productnew values(2,'Keyboard',600,15)
insert into productnew values(3,'Monitor',800,20)
insert into productnew values(4,'CPU',900,5)

select top 2 name,price from productnew order by price desc

select top 50 percent name,price from productnew order by price desc

insert into productnew values(5,'RAM',1000,25)

select * from productnew where name='CPU' or quantity=20 

select * from productnew where price>500 and id =3

select * from productnew where price between 500 and 800



