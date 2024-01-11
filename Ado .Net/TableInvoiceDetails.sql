create table TableInvoiceDetails(
Invoice_Detail_ID int identity,
Customer_Name varchar(500),
Customer_Contact varchar(15),
Product_Category_ID int,foreign key (Product_Category_ID) references TableProductCategory(Product_Category_ID),
Product_ID int,foreign key(Product_ID) references TableProduct(ProductID),
Residential_Type_ID int,
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

select * from TableInvoiceDetails
select * from TableProductGSTDetails