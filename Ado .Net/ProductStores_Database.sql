create database ProductStores

create table TableProductGSTDetails(
Product_Gst_ID int primary key,
Gst_Details_Name varchar(500),
CGST Decimal,
SGST Decimal,
IGST Decimal)


create table TableProductCategory(
Product_Category_ID int primary key,
Product_Type_Name varchar(500),
Product_Gst_ID int,
foreign key (Product_Gst_ID)
references TableProductGSTDetails(Product_Gst_ID))

create table TableProduct(
ProductID int primary key,
Product_Category_ID int,
Product_Name varchar(500),
foreign key(Product_Category_ID)
references TableProductCategory(Product_Category_ID)
)

insert into TableProductGSTDetails values(601,'AC and Fridge',14,14,14),
(602,'Computers',9,9,9),
(603,'Printers',9,9,9),
(604,'Mobiles',6,6,6)

insert into TableProductCategory values(1001,'Computers',602),
(1002,'Mobiles',604),
(1003,'Printers',603),
(1004,'AC and Fridge',601)

insert into TableProduct values(210,1002,'Apple'),
(211,1002,'Lenovo'),
(212,1003,'Samsung'),
(213,1004,'IFB'),
(214,1004,'LG'),
(215,1001,'Sony')