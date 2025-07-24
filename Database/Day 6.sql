----------------- Day 6 -----------------------
-- Task 1
-- Indexes
-- 1. Clustered Index
select * from Employees;

create table Branches
(
    Name nvarchar(50),
    Description nvarchar(max)
);

insert into Branches values('Ghi', 'Hurghada'), 
                            ('Abc', 'Cairo'), 
                            ('JKL', 'Alex.'), 
                            ('Def', 'Giza');

select * from Branches;
sp_helpindex Branches;

create clustered index ix_BranchNames on Branches(Name asc);

insert into Branches values('And', 'Luxor'), 
                            ('Badr', 'Cairo'), 
                            ('Afdal', 'Aswan');

---------------------------------------
--Task 2

-- nonclustered index
drop table Branches;

create table Branches (
    Id int primary key,
    Name nvarchar(50),
    City nvarchar(500)
);

insert into Branches (Id, Name, City) values 
(5, 'Ghi', 'Hurghada'),
(2, 'Abc', 'Cairo'),
(4, 'JKL', 'Alex.'),
(7, 'Def', 'Giza'),
(3, 'Amd', 'Luxor'),
(1, 'Badr', 'Cairo'),
(6, 'Afdal', 'Aswan'),
(10, 'Oasis', 'Alex.');

select * from Branches;
sp_helpindex Branches;

insert into Branches (Id, Name, City) values 
(11, 'Stars', 'Hurghada'),
(9, 'Moon', 'Luxor');

create unique nonclustered index ix_BranchNames on Branches (Name asc);
create nonclustered index ix_BranchCities on Branches (City asc);
