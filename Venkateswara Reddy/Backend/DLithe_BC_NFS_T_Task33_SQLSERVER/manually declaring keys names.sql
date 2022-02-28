use Dli;


CREATE TABLE CONSTRAINT_keydemo
(
ID INT,
NAME VARCHAR(25) NOT NULL,
AGE INT CHECK(AGE>18),             column level
ADDRESS VARCHAR(25) DEFAULT 'chennai',
CONSTRAINT PK_ID PRIMARY KEY(ID)
);


-----------------------------------------------
------------------------------------------------

CREATE TABLE CONSTRAINT_DEMO2
(
ID INT,
NAME VARCHAR(25) NOT NULL,
AGE INT,
ADDRESS VARCHAR(25) DEFAULT 'bangalore',
CONSTRAINT PK1_ID PRIMARY KEY(ID),   --table level
CONSTRAINT CK_AGE CHECK(AGE>18)
);


------------------------------------------------------
-------------------------------------------------------
--INSERTING MULTIPLE VALUES

INSERT INTO CONSTRAINT_DEMO2 VALUES
(1,'john',22,'chennai'),
(2,'smith',23,'bangalore'),
(3,'ravi',24,'chennai'),
(4,'venkatesh',22,'bangalore');


SELECT * FROM CONSTRAINT_DEMO2;