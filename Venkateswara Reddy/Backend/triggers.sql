--CREATE Trigger Database
create database triggers1;

use triggers1;


--crating employee table
CREATE TABLE Emp
(
  Id int Primary Key,
  Name nvarchar(30),
  Salary int,
  Gender nvarchar(10),
  DepartmentId int
)
GO


-- Insert data into Employee table
INSERT INTO Emp VALUES (1,'venkatesh', 20000, 'Male', 3)
INSERT INTO Emp VALUES (2,'Pritham', 2500, 'male', 2)
INSERT INTO Emp VALUES (3,'Anuradha', 65000, 'female', 1)
INSERT INTO Emp VALUES (4,'saran', 3700, 'Male', 2)
INSERT INTO Emp VALUES (5,'lekha', 70600, 'Female', 3)

select * from Emp
CREATE TRIGGER InsertError 
ON Emp
FOR INSERT
AS
BEGIN
PRINT 'You do not Have Permission Insert'
ROLLBACK TRANSACTION
END

INSERT INTO Emp VALUES (6,'Reshma', 69000, 'Female', 4)
--Output
--You do not Have Permission Insert
--Msg 3609, Level 16, State 1, Line 37
--The transaction ended in the trigger. The batch has been aborted.

--klajskf
--Update will work, not triggers
UPDATE Emp SET Salary = 15000 WHERE Id = 1
select * from Emp