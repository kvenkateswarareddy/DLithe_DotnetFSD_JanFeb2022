--stored procedures
-- insert update delete
--cache -xyz --pre compiled query 

--create stored procedure
use Dli
create procedure proc_DT
as
begin
   select * from Dlithe_uni where tid<4;
end

exec proc_DT

--alter sp(stored procedure)
alter procedure proc_DT
as
begin
   select * from Dlithe_uni where tid<4 and taddress='bangalore';
end

exec proc_DT

--drop
drop procedure proc_DT  -- to drop the procedure 


--STORED PARAMETER WITH INPUT PARAMETERS

create procedure proc_dt1(@taddress varchar(50))
as
begin
     select * from Dlithe_uni where taddress=@taddress
end

exec proc_dt1 @taddress='chennai'


--SP WITH OUPUT PARAMETERS
create procedure proc_dt2(@tid int output)
as
begin
     select @tid=max(tid) from Dlithe_uni --to get the maximum id
end

Declare @tid int

exec proc_dt2 @tid output    --to execute select the three  commands for output

print @tid


