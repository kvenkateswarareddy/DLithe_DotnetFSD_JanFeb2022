create database student
 use student
--creating table
 create table studetails
(
id int NOT NULL,
Name varchar(25),
mobile nvarchar(10),
department varchar(25)
);
-- insert records into the table
 insert into studetails values(1,'venkatesh',9951619130,'CSE');
 insert into studetails values(1,'raju',1234567891,'CSE');
 insert into studetails values(1,'charan',7689354266,'ece');
 insert into studetails values(1,'rahul',8345984578,'ece');
 insert into studetails values(1,'rekha',8681346254,'mba');
 insert into studetails values(1,'geetha',895643256,'mba');
 insert into studetails values(1,'rajesh',637892038,'civil');
 insert into studetails values(1,'lokesh', 456756798,'mech');
 insert into studetails values(1,'lekha',3456789987,'mech');


 select * from studetails
