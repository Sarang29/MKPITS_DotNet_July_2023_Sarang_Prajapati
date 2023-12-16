CREATE DATABASE ForeignKey

create table vendor_groups (groupid int identity primary key,groupname varchar(30) not null)

create table vendors (vendorid int identity primary key,
vendorname varchar(30),
groupid int not null,
constraint fk1 foreign key(groupid)
references vendor_groups(groupid))

select * from vendor_groups
select * from vendors

insert into vendor_groups values('Sarang')
insert into vendor_groups values('Akash')

insert into vendors values('David',1)
insert into vendors values('Lucky',1)
insert into vendors values('Sujit',2)
insert into vendors values('Chetan',2)


delete from vendors where groupid=2

delete from vendor_groups where groupid=2