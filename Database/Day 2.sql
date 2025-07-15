USE PearlySoft;

-- Filtering
SELECT FullName, Position, Salary, Country FROM Employees WHERE Position = 'Developer';

-- AND
SELECT * FROM Employees WHERE Position = 'Developer' AND Country = 'Egypt';
SELECT * FROM Employees WHERE Salary = 10500 AND Salary = 12500;

-- NOT: != or <>
SELECT * FROM Employees WHERE Position != 'Developer';
SELECT * FROM Employees WHERE Position <> 'Developer';

-- BETWEEN
SELECT * FROM Employees WHERE Salary BETWEEN 10500 AND 12500;
SELECT * FROM Employees WHERE Salary NOT BETWEEN 10500 AND 12500;

-- OR
SELECT * FROM Employees WHERE Country = 'Kuwait' OR Country = 'Oman';
SELECT * FROM Employees WHERE Country = 'Kuwait' OR Country = 'Oman';

-- IN
SELECT * FROM Employees WHERE Country IN ('Kuwait', 'Oman');
SELECT * FROM Employees WHERE Country NOT IN ('Kuwait', 'Oman');

-- SQL is case-insensitive

-- Wild Cards
-- % => zero or more characters
SELECT * FROM Employees WHERE FullName LIKE 'Ba%';
SELECT * FROM Employees WHERE FullName LIKE '%an%';
SELECT * FROM Employees WHERE FullName LIKE '%am%';

-- _ => one character
SELECT * FROM Employees WHERE FullName LIKE '_sama%';
SELECT * FROM Employees WHERE FullName LIKE 'a_l%';

-- [] => any character from the set
SELECT * FROM Employees WHERE FullName LIKE '[owz]%';
SELECT * FROM Employees WHERE FullName LIKE '[s]y%';
SELECT * FROM Employees WHERE FullName LIKE '%[dn]';

-- NOT LIKE
SELECT * FROM Employees WHERE FullName NOT LIKE '%[dn]';
SELECT * FROM Employees WHERE FullName NOT LIKE '[bmo]%';

-- ^ (caret) => NOT any character in the set
SELECT * FROM Employees WHERE FullName LIKE '%[^dn]';
SELECT * FROM Employees WHERE FullName LIKE '[^bmo]%';

-- Renaming column output
SELECT Id, FullName AS 'Employee Name' FROM Employees;
SELECT Id, FullName AS [Employee Name] FROM Employees;

--task 3
select *from employees order by FullName asc;
select *from employees order by FullName;
select *from employees order by FullName desc
select *from employees order by Salary asc
select *from employees order by Salary desc
select *from employees order by id asc
select *from employees order by id desc
select *from employees order by BirthDate asc
select *from employees order by BirthDate desc
select *from employees order by Country asc, FullName asc

--top n
select top 3 * from employees  
select top 3 * from employees  order by Salary asc
select top 3 * from employees  order by Salary desc

--distinct
select distinct Country from employees
select distinct Position from employees

--distinct & top
select distinct top 3 Salary from employees order by Salary desc


--task 4
--aliases
select FullName as employee, Position as job from employees
select FullName as 'full name', Position as job from employees
select FullName as [full name], Position as job from employees
select FullName + ' ('+Position+') ' as employee from employees

select *,(Salary*12) as 'annual salary' from employees
select *,(Salary*12) as [annual salary] from employees

--computed column
alter table employees add AnnualSalary as (salary * 12)
select * from employees


--task 5

select sum(Salary) as 'total salaries' from employees
select sum(Salary) as 'egypt salaries' from employees where Country='egypt'

select COUNT(id) as 'number of employees' from employees
select COUNT(*) as 'number of employees' from employees


--task 6
update employees set Salary=null where id in(4,6)
select count(Salary) as 'number of salaries' from employees
select count(Salary) as 'less than 10000 salaries' from employees where  Salary<10000

select AVG(Salary)  as 'average salary' from employees
select AVG(Salary) as 'egypt average salary' from employees where Country='egypt'

select MIN(Salary) as 'minumum salary' from employees
select max(Salary) as 'maximum salary' from employees


--task 7
select Country, COUNT(id) as 'number of employees' from employees group by Country
select Country, COUNT(id) as 'number of developers' from employees where Position like '%developers%' group by Country

select Position, COUNT(*) as [number of employees] from employees group by Position
select Position, COUNT(*) as [number of employees] from employees where Position like '%developers%' group by Position
select Position, COUNT(*) as [number of employees] from employees group by Position having COUNT(*)>1

select Country, SUM(Salary) as 'total salaries' from employees group by Country

select DepartmentID,COUNT(Id) as 'number of employees' from employees group by DepartmentID
select Country,Position, COUNT(*) as [number of employees] from employees group by Position,Country order by Country asc


--task 8 
insert into Employees values('Abc Def', '55944933922919', '1999/10/29', '2024/09/19 09:00:00','Secretary', 'Egypt', 8000, 1, null, 1);
insert into Employees values('Ghi JKL', '55244233222212', '1992/12/22', '2024/02/12 09:00:00','Accountant', 'Egypt', 11000, 1, null, 1);
select * from employees


--task 9

select * from departments inner join employees on departments.id=employees.DepartmentID order by departments.id
select * from employees inner join departments on employees.DepartmentID=departments.id order by employees.id

select employees.Id as empID,FullName,Position,DepartmentID,Country,departments.id as deptID, name,description 
from employees inner join departments 
on employees.DepartmentID=departments.id 
order by employees.id
