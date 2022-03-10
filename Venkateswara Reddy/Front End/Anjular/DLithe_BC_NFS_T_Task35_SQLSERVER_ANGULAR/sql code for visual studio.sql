

create database webapi;

use webapi;

create table UserRegistration
(
id int primary key identity,
Name varchar(25),
Email varchar(25),
Gender varchar(25),
Username varchar(25),
Password varchar(25)
)

select * from UserRegistration;

insert into UserRegistration values('Venkatesh','kvenky502@gmail.com','Male','venkatesh502','venky12345');