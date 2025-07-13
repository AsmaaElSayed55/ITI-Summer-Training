--------- Day 1 ---------
Create Database BrightStars;

Alter Database BrightStars Modify Name=LotusCo;

sp_renameDB 'LotusCo' , 'PearlySoft';

sp_renameDB 'PearlySoft' , 'ABC_Co';

alter database ABC_Co set single_user with rollback immediate;

drop Database ABC_Co;

Create Database PearlySoft;
-----------------------------------
use PearlySoft;
Create Table Sectors
(
	Id int,
	Name nvarchar(50),
	[Description] nvarchar(max)
)

Alter Table Sectors add Summary nvarchar(255); 
Alter Table Sectors add Budget decimal(18,2);

sp_rename 'Sectors.Budget' , 'AnnualBudget';

Alter Table Sectors Alter Column AnnualBudget int;
Alter Table Sectors Alter Column Description nvarchar(1000);
Alter Table Sectors drop column Summary; 

drop Table Sectors;

Use Pearlysoft;
Create Table Departments (
    Id Int Primary Key Identity(1,1),
    Name Nvarchar(50),
    Description Nvarchar(Max)
);

Insert Into Departments(Name, Description) Values ('Tm', 'Top management');
Insert Into Departments(Description) Values ('Web development');

Insert Into Departments Values 
    ('Qa', 'Quality assurance'),
    ('Mob dev', 'Mobile development'),
    ('Hr', 'Human resources');

Update Departments Set Name = 'Wd' Where Id = 2;
Update Departments Set Name = 'Md' Where Id = 4;
Update Departments Set Name = 'Qc', Description = 'Quality control' Where Id = 3;

Delete From Departments Where Id = 5;

Select * From Departments;
---------------------------------------------
Insert Into Departments(Name, Description) Values('Tm', 'Top management');
Insert Into Departments(Description) Values('Web development');

Insert Into Departments Values 
    ('Qa', 'Quality assurance'),
    ('Mob dev', 'Mobile development'),
    ('Hr', 'Human resources'),
    ('M&s', 'Marketing and sales');

Update Departments Set Name = 'Wd' Where Id = 2;
Update Departments Set Name = 'Md' Where Id = 4;
Update Departments Set Name = 'Qc', Description = 'Quality control' Where Id = 3;

Truncate Table Departments;

Select * From Departments;
--------------------------------------------
Create Table Employees
(
    Id Int Primary Key Identity (1,1),
    Fullname Nvarchar(60) Not Null,
    Nationalid Nvarchar(14) Unique,
    Birthdate Datetime2,
    Hiringdate Datetime2,
    Position Nvarchar(30),
    Country Nvarchar(25) Default 'Egypt',
    Salary Decimal(18,2) Check (Salary>=600 And Salary<=60000),
    Isactive Bit,
    Departmentid Int Foreign Key References Departments(Id) On Delete No Action,
    Managerid Int Foreign Key References Employees(Id) On Delete No Action
)

Insert Into Employees(Fullname, Nationalid, Birthdate, Hiringdate, Position, Salary, Isactive, Departmentid, Managerid)
Values ('Omar Hussain Ali', '10158962358744', '1980/2/18', '2005/10/13 09:00:00', 'Ceo', 49500.75, 1, 1, Null)

Select * From Employees

---------------------------------------------------------
insert into Employees values('Bahaa Mahmoud Farid', '60005000400033', '1980/5/16', '2009/11/22 09:30:00', 'CTO', 'Egypt', 42000.25, 1, 1, 1);

insert into Employees values('Ziyad Hassan Wahid', '10203040506070', '1985/10/27', '2012/12/24 09:00:00','Team Leader', 'Egypt', 22500, 1, 2, 2);

insert into Employees values('Hossam Ahmed Ali', '11122233344455', '1991/10/15', '2011/11/22 09:00:00', 'Team Leader', 'Egypt', 21500.25, 1, 3, 2);

insert into Employees values('Baraa Ashraf Essam', '10002000300044', '1993/12/29', '2012/12/24 09:00:00', 'Senior Tester', 'Kuwait', 12500.25, 1, 3, 4);

insert into Employees values('Mostafa Mohammed Hassan', '11022033044055', '1992/11/27', '2022/07/17 9:00:00', 'Senior Developer', 'Kuwait', 15000.75, 1, 2, 3);

insert into Employees values('Bassam Ayman Aly', '11002200330044', '1997/10/15', '2021/05/25 09:00:00', 'Developer', 'Egypt', 9200, 1, 2, 3);

insert into Employees values('Usama Mostafa Omar', '30002000100099', '1998/11/25', '2019/10/20 09:00:00', 'Tester', 'Kuwait', 6400, 1, 3, 4);

insert into Employees values('Samir Ahmed Taha', '90008000700066', '1988/10/27', '2017/09/18 09:00:00', 'Developer', 'Kuwait', 10500, 1, 2, 3);

insert into Employees values('Mahmoud Ashraf Saad', '90007000500033', '1994/7/20', '2020/11/03 09:00:00', 'Developer', 'Egypt', 11750, 1, 2, 3);

insert into Employees values('Osama Omar Talaat', '20004000600088', '1990/3/15', '2010/10/30 09:00:00', 'Developer', 'Oman', 12500, 1, 2, 3);

insert into Employees values('Bassam Hassan Allam', '99988877766655', '1987/12/13', '2024/02/12 09:00:00', 'Tester', 'Egypt', 12500, 1, 3, 4);

insert into Employees values('Nael Amr Othman', '10102020303044', '1986/11/20', '2020/12/24 9:00:00','Senior Developer', 'Kuwait', 17250, 1, 2, 3);

insert into Employees values('Ayman Mostafa Sallam', '90807060504030', '1995/5/27', '2023/08/28 09:00:00','Tester', 'Oman', 19500, 1, 3, 4);

insert into Employees values('Wael Mostafa Farid', '55544433322211', '1998/10/23', '2024/03/13 09:00:00','Tester', 'Egypt', 9500, 1, 3, 4);

Select *
from Employees

delete from Employees
Truncate Table Employees
