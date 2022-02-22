----creat table one ----
----CREATE TABLE EmployeeDemo
----(EmployeeID int, 
----FirstName varchar(50),
----LastName varchar(50),
----Age int,
----Gender varchar(50)
----)

----create table two----
--CREATE TABLE EmployeeSalary
--(EmployeeID int,
--JobTitle varchar(50),
--Salary int
--)

----add values to table employeedemo----
--Insert into EmployeeDemo VALUES
--(1002, 'Pam', 'Beasley', 30, 'Female'),
--(1003, 'Dwight', 'Schrute', 29, 'Male'),
--(1004, 'Angela', 'Martin', 31, 'Female'),
--(1005, 'Toby', 'Flenderson', 32, 'Male'),
--(1006, 'Michael', 'Scott', 35, 'Male'),
--(1007, 'Meredith', 'Palmer', 32, 'Female'),
--(1008, 'Stanley', 'Hudson', 38, 'Male'),
--(1009, 'Kevin', 'Malone', 31, 'Male')

--add values to employee salary table--
--Insert Into EmployeeSalary VALUES
--(1001, 'Salesman', 45000),
--(1002, 'Receptionist', 36000),
--(1003, 'Salesman', 63000),
--(1004, 'Accountant', 47000),
--(1005, 'HR', 50000),
--(1006, 'Regional Manager', 65000),
--(1007, 'Supplier Relations', 41000),
--(1008, 'Salesman', 48000),
--(1009, 'Accountant', 42000)

--show all cells from table--
--SELECT * FROM EmployeeDemo

--show top x rows from table--
--SELECT TOP 5 * FROM EmployeeDemo

--show first occurences of all different values 'gender' in table--
--SELECT DISTINCT (Gender) FROM EmployeeDemo

--show first occurences of all different values'gender' in table, but also count each occurence , COUNT shows this proof, group by does the work--
--SELECT Gender, COUNT(Gender)
--FROM EmployeeDemo
--GROUP BY Gender


-- This is doing the same thing, but further splitting results into the unique gender plus the specific age range-- 
--SELECT Gender, Age, COUNT(Gender)
--FROM EmployeeDemo
--GROUP BY Gender, Age

--Similar showing, narrows it down to males/females of age > 30, showing sum of those unique traits who meet criteria 
-- orders by desc instead of default asc
--SELECT Gender, COUNT(Gender) AS countGender
--FROM EmployeeDemo
--WHERE age > 31
--GROUP BY Gender
--ORDER BY countGender DESC
--Doing it by string value is a-z, z-a / numeric will do 0-larger and larger-0 respectively


--This is showing how you can order by 2 or more different parameters. Ordering by age asc but also splitting it into smaller 
--subgroups based on gender
--Can do numbers 1,2,3,4,5 left to right COLUMNS etc instead of explicit column name writing
--SELECT * 
--FROM EmployeeDemo
--ORDER BY Age , Gender

--Intermediate Skills
--Edit tables to include some null values in extra fields
--Insert into EmployeeSalary VALUES
--(1010, NULL, 47000),
--(NULL, 'Salesman', 43000)


--JOIN types here!
--SELECT * 
--FROM [SQL Tutorial].dbo.EmployeeDemo
--LEFT OUTER JOIN [SQL Tutorial].dbo.EmployeeSalary
--	ON EmployeeDemo.EmployeeID = EmployeeSalary.EmployeeID

--Cool demo of how to find the valid users and of those valid users, the highest salary at the top of table output
--EmployeeDemo.EmployeeID, FirstName, LastName, JobTitle, Salary
--SELECT EmployeeDemo.EmployeeID, FirstName, LastName, Salary
--FROM [SQL Tutorial].dbo.EmployeeDemo
--Inner JOIN [SQL Tutorial].dbo.EmployeeSalary
--	ON EmployeeDemo.EmployeeID = EmployeeSalary.EmployeeID
--WHERE FirstName <> 'Michael'
--ORDER BY Salary DESC


--Average Salesman salary
--Very cool!
--SELECT JobTitle, AVG(Salary) AS [Salary Average]
--FROM [SQL Tutorial].dbo.EmployeeDemo
--Inner JOIN [SQL Tutorial].dbo.EmployeeSalary
--	ON EmployeeDemo.EmployeeID = EmployeeSalary.EmployeeID
--Where JobTitle = 'Salesman'
--GROUP BY JobTitle




--Create Table WareHouseEmployeeDemographics 
--(EmployeeID int, 
--FirstName varchar(50), 
--LastName varchar(50), 
--Age int, 
--Gender varchar(50)
--)

--Insert into WareHouseEmployeeDemographics VALUES
--(1013, 'Darryl', 'Philbin', NULL, 'Male'),
--(1050, 'Roy', 'Anderson', 31, 'Male'),
--(1051, 'Hidetoshi', 'Hasagawa', 40, 'Male'),
--(1052, 'Val', 'Johnson', 31, 'Female')



--UNIONS
--SELECT *
--FROM [SQL Tutorial].dbo.EmployeeDemo
--Full Outer JOIN [SQL Tutorial].dbo.WareHouseEmployeeDemographics
--	ON EmployeeDemo.EmployeeID = WareHouseEmployeeDemographics.EmployeeID

--UNION will not show duplicates, UNION ALL will
--SELECT * 
--FROM [SQL Tutorial].dbo.EmployeeDemo
--UNION
--SELECT *
--FROM [SQL Tutorial].dbo.WareHouseEmployeeDemographics

--Demo for tables with differences in column name/size - works because type is int, string, int, however this is obviously not a core practice.
--SELECT EmployeeID, FirstName, Age
--FROM [SQL Tutorial].dbo.EmployeeDemo
--UNION
--SELECT EmployeeID, JobTitle, Salary
--FROM [SQL Tutorial].dbo.EmployeeSalary


--Case Statements

--SELECT FirstName, LastName, Age,
--CASE
--	WHEN Age = 38 Then 'Stanley'
--	WHEN Age > 30 Then 'Old'
	
--	ELSE 'Really Young'
--	--harsh
--	--cool though, this is just like the VB.NET Syntax
--END
--FROM [SQL Tutorial].dbo.EmployeeDemo
--Where Age IS NOT NULL
--ORDER BY Age


--SELECT FirstName, LastName, JobTitle, Salary,
--CASE 
--	WHEN JobTitle  = 'Salesman'  THEN Salary + (Salary * .10)
--	WHEN JobTitle = 'Accountant' THEN Salary + (Salary * .05)
--	WHEN JobTitle = 'HR' THEN Salary + (Salary * .000001)
--	ELSE Salary + (Salary * .03)
--END AS SalaryAfterRaise
--FROM [SQL Tutorial].dbo.EmployeeDemo
--JOIN [SQL Tutorial].dbo.EmployeeSalary
--	On EmployeeDemo.EmployeeID = EmployeeSalary.EmployeeID


--HAVING clause, when one cannot use the aggregate in query body, one shall use the having clause - Love it
--SELECT JobTitle, AVG(Salary) AS EmployeeSalAVG
--FROM [SQL Tutorial].dbo.EmployeeDemo
--JOIN [SQL Tutorial].dbo.EmployeeSalary
--	ON EmployeeDemo.EmployeeID = EmployeeSalary.EmployeeID
--GROUP BY JobTitle
--HAVING AVG(Salary) > 45000
--ORDER BY AVG(Salary)

--ADD and DELETE Info to tables IE: NULL cells
--SELECT *
--FROM [SQL Tutorial].dbo.EmployeeDemo

--UPDATE [SQL Tutorial].dbo.EmployeeDemo
--SET Age = 31 , Gender = 'Female'
--WHERE FirstName = 'Holly' AND LastName = 'Flax'


--DANGER: NO REVERSE FOR THIS FUNCTION-VERSION CONTROL WILL BE YOUR ONLY HOPE - TIP! - RUN SELECT STATEMENT RIGHT BEFORE AS IT WILL SHOW YOU WHAT
--WILL BE DELETED - IE: If there were no WHERE in this statement, [SQL Tutorial].dbo.EmployeeDemo would be entirely wiped
--DELETE FROM [SQL Tutorial].dbo.EmployeeDemo
--WHERE EmployeeID = 1005