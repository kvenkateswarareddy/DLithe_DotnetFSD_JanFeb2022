--NOT NULL
--PRIMARY KEY
create database Dli
use Dli
create table Dept1
(
Dno int Primary key,
Dname varchar(25)
)
-- insert (dept Table)
insert into Dept1 values (1,'.net')
insert into Dept1 values (2,'java')
insert into Dept1 values (3,'python')
insert into Dept1 values (4,'sql')

--select (dept table)
select * from Dept1

--foreign key(dept-emp)
create table emp
(
eid int Primary key,
ename varchar(25),
dno int Foreign key references Dept1(Dno)
)--foreign key

-- insert(emp table
insert into emp values(1001,'sahil',1);
insert into emp values(1002,'charan',2);
insert into emp values(1003,'venkatesh',2);

-- select 
select * from emp

-- check constraint
create table  project
(
prno int primary key,
prname varchar(25) check (prname like 'p1%'),
prclient varchar(25) default 'abc'   ---default value abc
)
-- insert
insert into project values(1,'p1001','te')
insert into project values(2,'p1002','te')
insert into project(prno,prname) values(3,'p1003') --default constructor

select * from project

-- unique
create table Dlithe_uni
(
tid int Primary key,
tname varchar(30) unique,
tsalary int default 35000,
taddress varchar(50) NOT NULL,
tdept varchar(10) check(tdept like 'dit%')
)
-- insert into Dlithe_uni
insert into Dlithe_uni values(10,'kiran',50000,'pune','ditdsoft');
select * from Dlithe_uni
insert into Dlithe_uni(tid,tname,taddress,tdept) values(20,'venkatesh','bangalore','dithard'); 
sp_rename 'CK__Dlithe_un__tdept__412EB0B6', 'Dlithe_const';  --to changing constraits name
sp_rename 'CK__project__prname__3B75D760', 'constraint_project';--for project table

--to changing constraits name
sp_rename 'DF__project__prclien__3C69FB99', 'constraint_project2';--for project table
--to changing constraits name

INSERT INTO                                           --for multiple values
	Dlithe_uni(tid, tname,tsalary,taddress,tdept)
VALUES
	(4,'john',55000,'chennai','ditdotnet'),
	(5,'smith',65000,'kadapa','ditjava'),
	(7,'venky',70000,'lolkatha','ditc#'),
	(9,'joel',25000,'chennai','ditjava'); 

	select * from Dlithe_uni