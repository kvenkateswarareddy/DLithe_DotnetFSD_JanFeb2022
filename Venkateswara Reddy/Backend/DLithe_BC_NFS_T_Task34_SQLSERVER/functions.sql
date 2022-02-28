--functions - sub programs
-- system and uder_defined
--system ->math, string, datetime
-- User-defined
--> Scalar - one value
-->Inline table--valued table  --cannot modify anything in table 
-->multi-statement table -valued

use Dli
--1)SCALAR
--2)Simple function

create function te(@a int)
Returns int
as
    begin
	     return @a+@a
	end

select dbo.te(10) as 'result'

create table emp2
(
id int primary key IDENTITY,
name varchar (25),
dob date
)

insert into emp2 values('smith','12/26/2000')
insert into emp2 values('john','12/26/1996')       --inserting multiple vakues
insert into emp2 values('smith','12/26/2002')
insert into emp2 values('smith','12/26/2004')
insert into emp2 values('smith','12/26/2008')
insert into emp2 values('smith','12/26/1999')
insert into emp2 values('smith','12/26/2020')
insert into emp2 values('smith','12/26/2001')

select * from emp2

-- creating a function for the dob column in emp2
create function calcage(@dob date)
returns int
as
begin
      declare @age int
	  set @age=DATEDIFF(year,@dob,getdate())
      return @age
end
select dbo.calcage('12/26/2000') as age

--get the difference of age from present to mentioned dob
select id,name,dob,dbo.calcage(dob)as age  from emp2

--2) INLINE table valued -RETURNS a table,only one statement can be used, begin and end is not required
create function int1_tb1(@id int)
returns table
as
	return (select * from emp2 where id=@id)

select * from int1_tb1(6)

select * from  Dlithe_uni

create function Dlithe_uni_fun(@dit varchar(25))
returns table
as
	return(select * from Dlithe_uni where tdept=@dit)
	--calling the function to execute the command 
	select * from Dlithe_uni_fun('DITjava')

--3) multi statement table valued-returns a table,more than one statement, begin and end must be used

create function multi_stmt()
returns @table table( id int,name varchar(25),department varchar(25))
as
	begin	
		insert into @table
		select tid,tname,tdept from Dlithe_uni where taddress='bangalore';
		return
	end

select * from multi_stmt();

select tid,tname,tdept from Dlithe_uni where Taddress='bangalore';