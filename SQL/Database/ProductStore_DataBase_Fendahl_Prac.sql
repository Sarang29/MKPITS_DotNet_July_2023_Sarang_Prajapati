create database PRODUCTSTORE

create table TableProductGSTDetails(
Product_Gst_ID int primary key,
Gst_Details_Name varchar(500),
CGST Decimal,
SGST Decimal,
IGST Decimal)

insert into TableProductGSTDetails values(1,'Commercial',10.00,20.00,30.00),
(2,'Domestic',05.00,04.00,03.00),
(3,'HouseHold',30.00,20.00,10.00)

select * from TableProductGSTDetails

create table TableProductCategory(
Product_Category_ID int primary key,
Product_Type_Name varchar(500),
Product_Gst_ID int,
constraint fk16 foreign key (Product_Gst_ID)
references TableProductGSTDetails(Product_Gst_ID))

insert into TableProductCategory values(1,'Brake Oil',1),
(2,'Engine Oil',1),
(3,'LPG Cylinder',2),
(4,'Detergent',3),
(5,'Cooking Oil',2),
(6,'VimBar',3)

select * from TableProductCategory

create table TableProduct(
ProductID int primary key,
Product_Category_ID int,
Product_Name varchar(500),
constraint fk17 foreign key(Product_Category_ID)
references TableProductCategory(Product_Category_ID)
)

insert into TableProduct values(1,1,'Castrol'),
(2,1,'Servo'),
(3,2,'Shell'),
(4,2,'Mobil'),
(5,3,'HP'),
(6,3,'Bharat'),
(7,4,'Wheel'),
(8,5,'Fortune'),
(9,6,'Vimbar')

select * from TableProduct

create table TableInvoiceDetails(
Invoice_Detail_ID int primary key,
Customer_Name varchar(500),
Customer_Contact varchar(15),
Product_Category_ID int,
Product_ID int,
Residential_Type_ID int,
Invoice_Date DateTime,
Quantity Decimal,
Price Decimal,
SGST Decimal,
CGST Decimal,
IGST Decimal,
SGST_Value Decimal,
CGST_Value Decimal,
IGST_Value Decimal,
TotalAmount int,
constraint fk18 foreign key (Product_Category_ID)
references TableProductCategory(Product_Category_ID),
constraint fk19 foreign key (Product_ID)
references TableProduct(ProductID)
)

insert into TableInvoiceDetails values(1,'Sarang','7378875065',1,1,1,'2023-12-12',4.5,50.0,1.86,2.58,3.65,3.9,2.8,1.5,500)
insert into TableInvoiceDetails values(2,'David','8578875065',2,2,2,'2023-12-15',35,40.0,1.65,3.58,3.10,5.9,1.8,3.5,8000)
insert into TableInvoiceDetails values(3,'Akash','9658875065',3,3,3,'2023-12-18',20,70.05,6.65,12.98,13.25,16.9,2.8,10.7,50000)

select * from TableProductGSTDetails
select * from TableProductCategory
select * from TableProduct
select * from TableInvoiceDetails