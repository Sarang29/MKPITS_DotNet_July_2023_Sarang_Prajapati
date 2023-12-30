CREATE DATABASE INSTITUTEDB

create table TableNation(
NationID int primary key,
NationName varchar(500))

insert into TableNation values(1,'Imagination')
insert into TableNation values(2,'Imagination')
insert into TableNation values(3,'Imagination')
select * from TableNation

create table TableState(
StateID int primary key,
NationID int,
StateName varchar(500),
constraint fk7 foreign key(NationID)
references TableNation(NationID))

insert into TableState values(1,1,'Maharashtra'),
(2,2,'UP'),
(3,3,'MP')

select * from TableState

create table TableCity(
CityId int primary key,
StateId int,
CityName varchar(500),
constraint fk8 foreign key(StateId)
references TableState(StateId))

insert into TableCity values(1,1,'Nagpur'),
(2,1,'Pune'),
(3,2,'Bihar'),
(4,2,'Ranchi'),
(5,3,'Jabalpur'),
(6,3,'Katni')

select * from TableCity

create table TableCourseRegDetail(
CourseRegID int primary key,
CategoryID int,
FullName varchar(1500),
GenderID int)

insert into TableCourseRegDetail values(1,1,'Sarang Prajapati',1),
(2,2,'David Kothe',1),
(3,3,'Sujit Khangar',2),
(4,4,'Akash Gautam',2),
(5,5,'Lucky Tambe',1)

select * from TableCourseRegDetail

create table TableRegAddress(
RegAddressID int primary key,
CourseRegID int,
NationID int,
StateID int,
CityID int,
constraint fk9 foreign key (CourseRegId)
references TableCourseRegDetail(CourseRegID),
constraint fk11 foreign key(NationID)
references TableNation(NationId),
constraint fk12 foreign key(StateID)
references TableState(StateId),
constraint fk13 foreign key(CityID)
references TableCity(CityID))

insert into TableRegAddress values(11,1,1,1,1),
(22,2,2,2,2),
(33,3,3,3,3)

select * from TableRegAddress

create table TableFeeDetail(
FeeID int primary key,
CourseRegID int,
TotalAmount Decimal,
MinPer decimal,
PaidAmount Decimal,
BalAmount Decimal,
PaidDate DateTime,
constraint fk15 foreign key(CourseRegID)
references TableCourseRegDetail(CourseRegID))

insert into TableFeeDetail values(1,1,50000,45.00,30000,20000,'2023-12-12')
insert into TableFeeDetail values(2,2,45000,50.00,20000,25000,'2023-12-15'),
(3,3,80000,70.00,70000,10000,'2023-12-18')

select * from TableNation
select * from TableState
select * from TableCity
select * from TableCourseRegDetail
select * from TableRegAddress
select * from TableFeeDetail

