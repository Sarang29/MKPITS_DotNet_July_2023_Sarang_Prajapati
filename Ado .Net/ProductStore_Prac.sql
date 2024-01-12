create database productprac

create table TableProductGSTDetails(
Product_Gst_ID int primary key,
Gst_Detail_Name varchar(500),
CGST decimal,
SGST decimal,
IGST decimal)

create table TableProductCategory(
Product_Category_ID int primary key,
Product_Type_Name varchar(500),
Product_Gst_ID int,foreign key (Product_Gst_ID) references TableProductGSTDetails(Product_Gst_ID))

create table TableProduct(
ProductID int primary key,
Product_category_ID int,foreign key(Product_Category_ID) references TableProductCategory(Product_Category_ID),
ProductName varchar(500),
Price int)

insert into TableProductGSTDetails values(601,'AC and Fridge',14,14,14),
(602,'Computers',9,9,9),
(603,'Printers',9,9,9),
(604,'Mobiles',6,6,6)

insert into TableProductCategory values(1001,'Computers',602),
(1002,'Mobiles',604),
(1003,'Printers',603),
(1004,'AC and Fridge',601)

insert into TableProduct values(210,1002,'Apple',40000),
(211,1002,'Lenovo',25000),
(212,1003,'Samsung',50000),
(213,1004,'IFB',20000),
(214,1004,'LG',30000),
(215,1001,'Sony',60000)

create table TableInvoiceDetails(
Invoice_Details_ID int primary key identity,
Customer_Name varchar(500),
Customer_Contact varchar(15),
Product_Category_ID int,
Product_ID int,
Residentail_Type_ID int,
Invoice_Date datetime,
Quantity decimal,
Price decimal,
CGST decimal,
SGST decimal,
IGST decimal,
CGST_Value decimal,
SGST_Value decimal,
IGST_Value decimal,
TotalAmount decimal)

select * from TableProductGSTDetails
select * from TableProductCategory
select * from TableProduct