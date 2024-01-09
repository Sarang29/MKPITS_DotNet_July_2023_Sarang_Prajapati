create database CourseDb

create table TableNation(
NationID int primary key,
NationName varchar(max))

create table TableState(
StateID int primary key,
NationID int,
StateName varchar(max),
foreign key(NationID) references TableNation(NationID))

create table TableCity(
CityID int primary key,
StateID int,
CityName varchar(max),
foreign key(StateID) references TableState(StateID))

insert into TableNation values(1,'India'),
(2,'United-nation'),
(3,'Nepal'),
(4,'Sri Lanka')

insert into TableState values(101,1,'Andhra Pradesh'),
(102,1,'Punjab'),
(103,2,'California'),
(104,2,'Florida'),
(105,3,'Koshi'),
(106,3,'bagmati'),
(107,4,'Colombo'),
(108,4,'Ratnapur')

insert into TableCity values(1001,101,'Visakhapatnam'),
(1002,101,'Vijaywada'),
(1003,101,'Guntur'),
(1004,102,'Amritsar'),
(1005,102,'Jalandhar'),
(1006,102,'Chandigarh'),
(1007,103,'Los Angeles'),
(1008,103,'San Jose'),
(1009,103,'San Deigo'),
(1010,104,'Jacksonville'),
(1011,104,'Miami'),
(1012,104,'Tampa'),
(1013,105,'damak'),
(1014,105,'Dharan'),
(1015,105,'Biratnagar'),
(1016,106,'Banepa'),
(1017,106,'Bharatput'),
(1018,106,'Hetauda'),
(1019,107,'Grandpass'),
(1020,107,'borella'),
(1021,107,'Pettah'),
(1022,108,'Balangoda'),
(1023,108,'Kolonna'),
(1024,108,'Panamure')



