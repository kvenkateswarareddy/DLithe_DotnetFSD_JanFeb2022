-- create dlithe--
create database Dlithe
 use Dlithe
 create table trainees
 (
 ID int NOT NULL,
 Name varchar(25) NOT NULL
 );
 -- insert records into the table
 insert into trainees values(1,'venkatesh');
 -- Select
 select * from trainees
 select id from trainees
 --alter
 alter table trainees add deptname varchar(25)
 --update
 update trainees set deptname='cse' where id=1
 -- insert multiple records
  insert into trainees values(2,'venkatesh','cse');
  insert into trainees values(3,'rahul','ece');
  insert into trainees values(4,'ravi','ece');
  insert into trainees values(5,'kiran','mca');
  insert into trainees values(6,'ravi','it');
  -- select ( condition - where clause
  select * from trainees wher deptname ='it'
  select * from trainees where id > 2 and id < 6  --RELATIONAL/LOGICAL
  select * from trainees where id between 2 AND 6  --RANGE OPERATOR
  select * from trainees where Name like 'r%'
  select * from trainees where Name like 'v%' --like operator


  --create schema
  create schema TE

-- create table inside the schema TE
create table TE.Martr
(
id int NOT NULL,
Name varchar(25),
mobile nvarchar(10),
department varchar(25)
);

-- drop schema
drop schema if exists TE  --shows error
--drop  table marchtrainees
drop table TE.Martr

--delete recordes from a table
delete from trainees where deptname='it' --to delete 'it' dept records only 

-- Truncate
truncate table

--update command
update trainees set deptname='ece' where id=2


---Constraints
