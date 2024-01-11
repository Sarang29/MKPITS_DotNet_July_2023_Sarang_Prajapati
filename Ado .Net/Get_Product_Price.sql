select * from TableProductGSTDetails
select * from TableProductCategory
select * from TableProduct

create table TableProduct(
ProductID int primary key,
Product_Category_ID int,
Product_Name varchar(500),
Product_Price int,
foreign key(Product_Category_ID)
references TableProductCategory(Product_Category_ID)
)

insert into TableProduct values(210,1002,'Apple',40000),
(211,1002,'Lenovo',25000),
(212,1003,'Samsung',50000),
(213,1004,'IFB',20000),
(214,1004,'LG',30000),
(215,1001,'Sony',60000)
