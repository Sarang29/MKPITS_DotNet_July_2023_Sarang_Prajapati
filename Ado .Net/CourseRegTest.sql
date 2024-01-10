create database CourseTest


create table TableNation(
NationID int primary key,
NationName varchar(max))

create table TableState(
StateID int primary key,
NationID int,
foreign key(NationID) references TableNation(NationID),
StateName varchar(max))

create table TableCity(
CityID int primary key,
StateID int,
foreign key(StateID) references TableState(StateID),
CityName varchar(max))

insert into TableNation values(1,'India'),
(2,'United Nation'),
(3,'Nepal'),
(4,'Sri Lanka')

insert into TableState values(101,1,'Maharashtra'),
(102,1,'Madhya Pradesh'),
(103,2,'California'),
(104,2,'Florida'),
(105,3,'Colombo'),
(106,3,'Dhaka'),
(107,4,'Ratnapur'),
(108,4,'Bharatpur')

insert into TableCity values(1001,101,'Nagpur'),
(1002,101,'Pune'),
(1003,102,'Jabalpur'),
(1004,102,'Katni'),
(1005,103,'Los Angeles'),
(1006,103,'San Jose'),
(1007,104,'New Jersey'),
(1008,104,'San Deigo'),
(1009,105,'Patna'),
(1010,105,'Bihar'),
(1011,106,'Kolhapur'),
(1012,106,'Amravati'),
(1013,107,'Bhandara'),
(1014,107,'Nashik'),
(1015,108,'Bangkok'),
(1016,108,'Thailand')

select * from TableNation
select * from TableState
select * from TableCity


create table TableCourseRegDetail(
CourseRegID int primary key identity,
CategoryID int,
FullName varchar(1500),
GenderID int)

create table TableRegAddress(
RegAddressID int primary key identity,
CourseRegID int,foreign key (CourseRegID) references TableCourseRegDetail(CourseRegID),
NationID int,foreign key (NationID) references TableNation(NationID),
StateID int,foreign key(StateID) references TableState(StateID),
CityID int,foreign key(CityID) references TableCity(CityID))


create table TableFeeDetail(
FeeID int primary key identity,
CourseRegID int,foreign key(CourseRegID) references TableCourseRegDetail(CourseRegID),
TotalAmount Decimal,
MinPer decimal,
PaidAmount decimal,
BalAmount decimal,
PaidDate Datetime)

select * from TableCourseRegDetail
select * from TableRegAddress
select * from TableFeeDetail

