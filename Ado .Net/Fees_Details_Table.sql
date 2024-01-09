create table TableCourseRegDetail(
CourseRegID int primary key identity,
CategoryID int,
FullName varchar(1500),
GenderID int)


create table TableRegAddress(
RegAddressID int primary key identity,
CourseRegID int,
NationID int,
StateID int,
CityID int,
foreign key(CourseRegID) references TableCourseRegDetail(CourseRegID),
foreign key(NationID) references TableNation(Nation_ID),
foreign key(StateID) references TableState(State_ID),
foreign key(CityID) references TableCity(City_ID))

create table TableFeeDetail (
FeeID int primary key identity,
CourseRegID int,
TotalAmount Decimal,
MinPer decimal,
PaidAmount decimal,
BalAmount decimal,
PaidDate date,
foreign key(CourseRegID) references TableCourseRegDetail(CourseRegID))


