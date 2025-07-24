------------- Day 5 ---------------
-- Task 1

CREATE PROCEDURE sp_Insert_Department
    @Name NVARCHAR(50),
    @Description NVARCHAR(MAX)
AS
BEGIN
    INSERT INTO Departments(Name, Description)
    VALUES(@Name, @Description);
END;

-----------------------------------------------------
-- Task 2

CREATE PROCEDURE sp_Select_Department @id INT
AS
BEGIN
    SELECT * FROM Departments WHERE Id = @id;
END

EXECUTE sp_Select_Department 3;


-----------------------------------------------------
-- Task 3

CREATE PROCEDURE sp_Update_Department
    @id INT,
    @name NVARCHAR(50),
    @description NVARCHAR(MAX)
AS
BEGIN
    UPDATE Departments
    SET Name = @name,
        Description = @description
    WHERE Id = @id;
END;

EXECUTE sp_Update_Department 8, 'CS', 'Customer Support';
SELECT * FROM Departments;


-----------------------------------------------
-- Task 4

CREATE PROCEDURE sp_Delete_Department @id INT
AS
BEGIN
    DELETE FROM Departments WHERE Id = @id;
END;

EXECUTE sp_Delete_Department 7;
SELECT * FROM Departments;


-----------------------------------------------
-- Task 5

-- Stored Procedure to get current year
CREATE PROCEDURE sp_GetCurrentYear
AS
BEGIN
    RETURN YEAR(GETDATE());
END
-- Execute the procedure and store result in a variable
DECLARE @currentYear INT;
EXECUTE @currentYear = sp_GetCurrentYear;
SELECT @currentYear AS 'Current Year';
-- Scalar-valued Function to get current year
CREATE FUNCTION getCurrentYear()
RETURNS INT
BEGIN
    RETURN YEAR(GETDATE());
END
-- Invoke the function in two ways
SELECT dbo.getCurrentYear() AS 'Current Year';  -- Inline execution
SELECT dbo.getCurrentYear() AS 'Current Year';  -- Inline execution


------------------------------------------------
-- Task 6

-- Transaction Block with Error Handling
BEGIN TRY
    BEGIN TRANSACTION
        INSERT INTO Departments VALUES ('AAA', 'MMM');
        UPDATE Departments SET Name = 'QA', Description = 'Quality Assurance' WHERE Id = 3;
        DELETE FROM Departments WHERE Id = 2; -- May trigger foreign key conflict
    COMMIT TRANSACTION
END TRY
BEGIN CATCH
    ROLLBACK TRANSACTION;
    SELECT ERROR_MESSAGE() AS 'Error';
END CATCH

-- View final state of Departments table
SELECT * FROM Departments;


-----------------------------------------------
-- Task 7

-- Create DepartmentActions table to log department events
CREATE TABLE DepartmentActions (
    Id INT PRIMARY KEY IDENTITY(1, 1),
    Action NVARCHAR(MAX),
    DateAndTime DATETIME2
);

-- View all logged department actions
SELECT * FROM DepartmentActions;

-- 1. Example setup for an AFTER trigger will go here (not included in the image)

-----------------------------------------------
-- Task 8
-- 1. Trigger that logs insertions into the Departments table
CREATE TRIGGER tr_Departments_Insert
ON Departments
FOR INSERT
AS
BEGIN
    DECLARE @deptId INT, @deptName NVARCHAR(50);
    SELECT @deptId = Id, @deptName = Name FROM inserted;

    INSERT INTO DepartmentActions
    VALUES('A new department with Id: ' + CAST(@deptId AS NVARCHAR(50)) +
           ' and name: ' + @deptName +
           ' was inserted into Departments table.', GETDATE());
END
-- Insert a sample department
INSERT INTO Departments VALUES('P&P', 'Procurement and Purchases');
-- Display logged actions
SELECT * FROM DepartmentActions


------------------------------------------------
-- Task 9

-- 1. Trigger that logs updates to the Departments table
CREATE TRIGGER tr_Departments_Update
ON Departments
AFTER UPDATE
AS
BEGIN
    
	DECLARE @deptId INT;
    SELECT @deptId = Id FROM inserted;
    
	DECLARE @deptName NVARCHAR(50);
    SELECT @deptName = Name FROM inserted;
    
	DECLARE @deptDescription NVARCHAR(MAX);
    SELECT @deptDescription = Description FROM inserted;
	
	INSERT INTO DepartmentActions
    VALUES(
        'The departments table row with Id ' + CAST(@deptId AS NVARCHAR(50)) +
        ' was update. the name : ' + @deptName +
        '. The description : ' + @deptDescription + '.',
        GETDATE()
    );
END
-- Example update
UPDATE Departments SET Name = 'ABCD', Description = 'Def Ghi' WHERE Id = 4;

-- View results
SELECT * FROM Departments;
SELECT * FROM DepartmentActions


---------------------------------------------------------
-- Task 10

-- INSTEAD OF DELETE Trigger
CREATE TABLE Sales (
    Id INT PRIMARY KEY IDENTITY(1,1),
    CustomerName NVARCHAR(50),
    Amount DECIMAL(18,2),
    DeletedFlag BIT
);

-- Insert sample records
INSERT INTO Sales(CustomerName, Amount) VALUES('Osama Ahmed', 13000.25);
INSERT INTO Sales(CustomerName, Amount) VALUES('Bahaa Ali', 15000.75);
INSERT INTO Sales(CustomerName, Amount) VALUES('Ayman wael', 14200.50);

-- Create INSTEAD OF DELETE trigger
CREATE TRIGGER tr_Sales_InsteadOfDelete
ON Sales
INSTEAD OF DELETE
AS
BEGIN
    DECLARE @SalesId INT;
    SELECT @SalesId = Id FROM deleted;
    UPDATE Sales SET DeletedFlag = 1 WHERE Id = @SalesId;
END

-- Display current Sales table
SELECT * FROM Sales;

-- Attempt to delete a record (will mark as deleted instead)
DELETE FROM Sales WHERE Id = 2;

-- Display non-deleted records
SELECT Id, CustomerName, Amount

FROM Sales
WHERE DeletedFlag = 0 OR DeletedFlag IS NULL;

----------------------------------------------------
-- Assignment

create trigger tr_Department_delete
on Departments
for delete
as
begin
    declare @deptId int;
    select @deptId = Id from deleted;
    declare @deptName nvarchar(50);
    select @deptName = Name from deleted;
    declare @deptDescription nvarchar(max);
    select @deptDescription = Description from deleted;

    insert into DepartementActions values('The departments table row with Id ' + cast(@deptId as nvarchar(50)) +
    ' and name: ' + @deptName +
    ' and description: ' + @deptDescription +
    ' was deleted.', GETDATE());
end
go
select * from Departments;
delete from Departments where Id = 15;
select * from DepartementActions
