-- Task 1

USE PearlySoft;

SELECT Employees.Id, 
       FullName AS Employee, 
       Position, 
       Country, 
       Departments.Name AS Department
FROM Employees 
INNER JOIN Departments ON Employees.DepartmentId = Departments.Id;

-- Task 2

SELECT Employees1.Id, 
       Employees1.FullName AS Employee, 
       Employees1.Position, 
       Employees1.Country, 
       Employees1.ManagerId,
       Employees2.Id, 
       Employees2.FullName + ' (' + Employees2.Position + ')' AS Manager
FROM Employees AS Employees1 
INNER JOIN Employees AS Employees2 
ON Employees2.Id = Employees1.ManagerId;

-- Task 3

SELECT Departments.Id, 
       Name + '(' + Description + ')' AS Department,
       FullName + '(' + Position + ')' AS Employee, 
       Employees.DepartmentId
FROM Departments 
INNER JOIN Employees ON Departments.Id = Employees.DepartmentId
ORDER BY Departments.Id;


-- Task 4

SELECT Managers.Id, 
       Managers.FullName + '(' + Managers.Position + ')' AS Manager,
       Employees.FullName + '(' + Employees.Position + ')' AS Employee, 
       Employees.ManagerId
FROM Employees AS Managers 
INNER JOIN Employees ON Managers.Id = Employees.ManagerId
ORDER BY Managers.Id;


--Assignment

SELECT Employees.Id, 
       Employees.FullName + '(' + Employees.Position + ')' AS Employee, 
       Managers.FullName + '(' + Managers.Position + ')' AS Manager, 
       Name + '(' + Description + ')' AS Department 
FROM Employees 
INNER JOIN Employees AS Managers ON Employees.ManagerId = Managers.Id 
INNER JOIN Departments ON Employees.DepartmentId = Departments.Id;


-- Task 5

SELECT *
FROM Departments AS dept 
LEFT OUTER JOIN Employees AS emp 
ON emp.DepartmentId = dept.Id;


-- Task 6

SELECT *
FROM Employees 
LEFT OUTER JOIN Departments 
ON Departments.Id = Employees.DepartmentId;


-- Task 7

SELECT * 
FROM Departments 
RIGHT OUTER JOIN Employees 
ON Departments.Id = Employees.DepartmentId;


-- Task 8

SELECT * 
FROM Employees 
RIGHT OUTER JOIN Departments 
ON Departments.Id = Employees.DepartmentId;


-- Task 9

SELECT * 
FROM Departments 
FULL OUTER JOIN Employees 
ON Departments.Id = Employees.DepartmentId;


-- Task 10

SELECT * 
FROM Employees 
FULL OUTER JOIN Departments 
ON Departments.Id = Employees.DepartmentId;


-- Task 11
-- (3) Cross Join

CREATE TABLE Chemicals (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50) NOT NULL UNIQUE
);

INSERT INTO Chemicals VALUES 
('Chemical 01'), 
('Chemical 02'), 
('Chemical 03');

SELECT * FROM Chemicals;

CREATE TABLE Plants (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50) NOT NULL UNIQUE
);

INSERT INTO Plants VALUES 
('Plant 01'), 
('Plant 02'), 
('Plant 03');

SELECT * FROM Plants;

SELECT 
    Chemicals.Name, 
    Plants.Name, 
    '' AS Notes
FROM Chemicals 
CROSS JOIN Plants
ORDER BY Chemicals.Name;


-- Task 12
-- Sub-Query -> More readable
-- Join is better in performance (faster)

SELECT FullName, Position,
    (SELECT Name + ' (' + Description + ')' 
     FROM Departments 
     WHERE Id = DepartmentId) AS 'Department'
FROM Employees;

---- Task 13

create view EgyptEmployeesView as 
select Id, FullName, NationalId, BirthDate, Country 
from Employees 
where Country = 'Egypt';

select * from EgyptEmployeesView;

insert into EgyptEmployeesView(FullName, NationalId, BirthDate, Country)
values('Ali Mamdouh Sayed', '101012020203', '1998/2/14 00:00:00', 'Egypt');

update EgyptEmployeesView 
set FullName = 'Ashraf Salah Hassan' 
where Id = 1016;

delete from EgyptEmployeesView 
where Id = 1016;

select * from EgyptEmployeesView;
