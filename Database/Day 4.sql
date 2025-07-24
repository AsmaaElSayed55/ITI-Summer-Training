-------------- Day 4 -----------------------

-- Task 1

USE PearlySoft;

-- Variables
-- Declare variable --> DECLARE @Variable_Name Data_Type
DECLARE @NumberOfStudents TINYINT; -- 0 to 255 (1 byte)

-- Value Assignment
-- SET @Variable_Name = VALUE or SELECT @Variable_Name = VALUE
SET @NumberOfStudents = 60;

-- Initialization
DECLARE @NumberOfCustomers SMALLINT = 500; -- (-32,768 to 32,767) (2 bytes)
SET @NumberOfCustomers += 20;
SET @NumberOfCustomers -= 5;

-- INT (-2,147,483,648 to 2,147,483,647) (4 bytes)
-- BIGINT (-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807) (8 bytes)

-- Display Value
SELECT @NumberOfStudents AS 'Number of Students';
PRINT (@NumberOfCustomers);

-- Declare variable
-- Syntax: DECLARE @Variable_Name Data_Type
DECLARE @NumberOFStudents TINYINT; -- Range: 0 to 255 (1 byte)

-- Value Assignment
-- You can assign with SET or SELECT
SET @NumberOFStudents = 60;

-- Initialization with arithmetic operations
DECLARE @NuberOfCustomers SMALLINT = 500; -- Range: -32,768 to 32,767 (2 bytes)
SET @NuberOfCustomers += 20;
SET @NuberOfCustomers -= 5;

-- Data Type Notes
-- INT: -2,147,483,648 to 2,147,483,647 (4 bytes)
-- BIGINT: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 (8 bytes)

-- Display the values
SELECT @NumberOFStudents AS 'Number of Students';
PRINT(@NuberOfCustomers);


--------------------------------------------
-- Task 2

-- BIT Data Type
DECLARE @isGraduate BIT; -- Possible values: 0, 1, or NULL (1 byte)
SET @isGraduate = 1;

-- Display BIT Value
SELECT @isGraduate AS [isGraduate Value];

-- Display BIT Memory Size
SELECT DATALENGTH(@isGraduate) AS 'isGraduate Memory Size'; -- Returns memory size in bytes

-- DECIMAL Data Type (precision, scale)
-- Memory usage:
-- 1–9 precision → 5 bytes
-- 10–19 precision → 9 bytes
-- 20–28 precision → 13 bytes
-- 29–38 precision → 17 bytes

DECLARE @salary DECIMAL(18,2); -- Precision: 18, Scale: 2
SET @salary = 17500.25;

-- Display Salary Value
SELECT @salary;


--------------------------------------------
-- Task 3

-- char (1 to 8000 characters) — Fixed size, 1 byte per character
DECLARE @charTest CHAR(10);
SET @charTest = 'Egypt';
PRINT('[' + @charTest + ']');
PRINT(DATALENGTH(@charTest));

-- varchar (1 to 8000 characters) — Variable size, 1 byte per character
DECLARE @varcharTest VARCHAR(10);
SET @varcharTest = 'Egypt';
PRINT('[' + @varcharTest + ']');
PRINT(DATALENGTH(@varcharTest));

-- nchar (1 to 4000 characters) — Fixed size, 2 bytes per character
DECLARE @ncharTest NCHAR(10);
SET @ncharTest = N'مصر';
PRINT('[' + @ncharTest + ']');
PRINT(DATALENGTH(@ncharTest));

-- nvarchar (1 to 4000 characters) — Variable size, 2 bytes per character
DECLARE @nvarcharTest NVARCHAR(10);
SET @nvarcharTest = N'مصر';
PRINT('[' + @nvarcharTest + ']');
PRINT(DATALENGTH(@nvarcharTest));


--------------------------------------------
-- Task 4

-- nvarchar(max) overview:
-- - Supports up to 2GB of characters
-- - Uses flexible memory allocation
-- - Cannot be used as a key column in an index
-- - No character limit enforcement

DECLARE @nvarcharTest2 NVARCHAR(10);
SET @nvarcharTest2 = N'لغة الاستعلامات الهيكلية';

PRINT('|' + @nvarcharTest2 + '|');
PRINT(DATALENGTH(@nvarcharTest2));  -- Outputs byte size

DECLARE @nvarcharMaxTest NVARCHAR(MAX);
SET @nvarcharMaxTest = N'لغة الاستعلامات الهيكلية';

PRINT('|' + @nvarcharMaxTest + '|');
PRINT(DATALENGTH(@nvarcharMaxTest));  -- Shows actual storage used


--------------------------------------------
-- Task 5

-- Implicit Data Type Conversion:
-- Precedence: DateTime > Numeric > Character String
DECLARE @price FLOAT;
SET @price = 1500.75;
SELECT 'Price: ' + @price;

-- Explicit Data Type Conversion:
-- Using CAST
DECLARE @price FLOAT = 1500.75;
SELECT 'Price: ' + CAST(@price AS NVARCHAR);
-- Using CONVERT
SELECT 'Price: ' + CONVERT(NVARCHAR, @price);


---------------------------------------------------
-- Assignment 1

-- Conditional Statements
-- if
DECLARE @score FLOAT;
SET @score = 57;

IF(@score >= 50)
BEGIN
    PRINT 'Passed';
END
ELSE
BEGIN
    PRINT 'Failed';
END
--------------------------------------------
-- Assignment 2

DECLARE @score FLOAT;
SET @score = 39;
IF @score >= 90
    PRINT 'Perfect';
ELSE IF @score >= 80
    PRINT 'Very Good';
ELSE IF @score >= 65
    PRINT 'Good';
ELSE IF @score >= 50
    PRINT 'Passed';
ELSE IF @score >= 40
    PRINT 'Poor';
ELSE
    PRINT 'Very Poor';


--------------------------------------------
-- Task 6

-- CASE expression to classify nationality
SELECT FullName, 
       CASE 
           WHEN Country = 'Egypt' THEN 'Citizen' 
       END 
FROM Employees;

-- CASE with ELSE to handle other countries
SELECT FullName, 
       CASE 
           WHEN Country = 'Egypt' THEN 'Citizen' 
           ELSE 'Foreigner' 
       END 
FROM Employees;

-- Update activity status
UPDATE Employees SET IsActive = 0 WHERE Id = 0 OR Id = 10;
UPDATE Employees SET IsActive = NULL WHERE Id IN (12, 14);

-- Classify activity status using CASE
SELECT FullName, 
       CASE 
           WHEN IsActive = 1 THEN 'Available' 
           WHEN IsActive = 0 THEN 'Unavailable' 
           ELSE 'Unspecified' 
       END 
FROM Employees;

-- Display full employee data
SELECT * FROM Employees;


------------------------------
--Task 6

-- CASE expression: Evaluate citizenship based on country
SELECT FullName, 
       CASE 
           WHEN Country = 'Egypt' THEN 'Citizen' 
       END 
FROM Employees;
-- CASE with ELSE: Provide default classification
SELECT FullName, 
       CASE 
           WHEN Country = 'Egypt' THEN 'Citizen' 
           ELSE 'Foreigner' 
       END 
FROM Employees;

-- Update activity status based on ID
UPDATE Employees SET IsActive = 0 WHERE Id = 0 OR Id = 10;
UPDATE Employees SET IsActive = NULL WHERE Id IN (12, 14);

-- CASE expression: Interpret IsActive values
SELECT FullName, 
       CASE 
           WHEN IsActive = 1 THEN 'Available'
           WHEN IsActive = 0 THEN 'Unavailable'
           ELSE 'Unspecified'
       END 
FROM Employees;

-- Display complete employee data
SELECT * FROM Employees;


--------------------------------------------
-- Assignment 3

-- Print numbers from 0 to 9 using a WHILE loop
DECLARE @i INT = 0;
WHILE (@i < 10)
BEGIN
    PRINT @i;
    SET @i += 1;
END
-- Print odd numbers from 1 to 10 using WHILE and CONTINUE
DECLARE @j INT = 0;
WHILE (@j < 10)
BEGIN
    SET @j += 1;
    IF (@j % 2 = 0)
    BEGIN
        CONTINUE;
    END
    PRINT @j;
END

-- WHILE loop using CONTINUE to skip even numbers and print odd numbers from 1 to 9
DECLARE @j INT = 0;
WHILE (@j < 10)
BEGIN
    SET @j += 1;
    IF (@j % 2 = 0)
    BEGIN
        CONTINUE;
    END
    PRINT @j;
END

-- WHILE loop using BREAK to stop the loop when @k equals 5
DECLARE @k INT = 0;
WHILE (@k < 10)
BEGIN
    SET @k += 1;
    PRINT @k;
    IF (@k = 5)
    BEGIN
        BREAK; -- stop the loop
    END
END

-- Print numbers from 0 to 9 using WHILE loop
DECLARE @i INT = 0;
WHILE(@i < 10)
BEGIN
    PRINT @i;
    SET @i += 1;
END

-- Print odd numbers from 1 to 10 using WHILE and CONTINUE
DECLARE @j INT = 0;
WHILE(@j < 10)
BEGIN
    SET @j += 1;
    IF (@j % 2 = 0)
    BEGIN
        CONTINUE;
    END
    PRINT @j;
END


-------------------------------------------
-- Assignment 4

-- System/Built-in/Pre-defined Functions
-- Aggregate & Character String Functions

SELECT UPPER('SSQL Server');
SELECT LOWER('SSQL Server');
SELECT '|' + LTRIM(' SQL Server ') + '|';
SELECT '|' + RTRIM(' SQL Server ') + '|';
SELECT '|' + TRIM(' SQL Server ') + '|';

SELECT LEN('SQL Server');
SELECT CHARINDEX('e', 'SQL Server');
SELECT REPLACE('SQL Server', 'Server', 'Database');
SELECT LEFT('SQL Server', 5);
SELECT RIGHT('SQL Server', 5);
SELECT SUBSTRING('SQL Server', 5, 3);


--------------------------------------------
-- Assignment 5

-- Mathematical Functions:
SELECT SQRT(81);             -- Square root of 81
SELECT FLOOR(4.9);           -- Round down to nearest integer
SELECT CEILING(7.1);         -- Round up to nearest integer
SELECT ROUND(3.567, 0);      -- Round to 0 decimal places
SELECT ROUND(3.567, 1);      -- Round to 1 decimal place
SELECT ROUND(3.567, 2);      -- Round to 2 decimal places
SELECT ROUND(3.567, 3);      -- Round to 3 decimal places

--------------------------------------------
-- Assignment 6

-- Date Functions:
SELECT GETDATE();                   -- Returns current date and time
SELECT GETUTCDATE();                -- Returns current UTC date and time

SELECT ISDATE('27-12-1994');        -- Checks if string is a valid date
SELECT ISDATE('1994-12-27');        -- Same check using ISO format

SELECT DATENAME(YEAR, '1994-12-27');   -- Extracts year
SELECT DATENAME(MONTH, '1994-12-27');  -- Extracts month name
SELECT DATENAME(WEEK, '1994-12-27');   -- Extracts week number

-- Extract various components of the date using DATENAME
SELECT DATENAME(YEAR, '1994-12-27');
SELECT DATENAME(MONTH, '1994-12-27');
SELECT DATENAME(WEEK, '1994-12-27');
SELECT DATENAME(DAY, '1994-12-27');
SELECT DATENAME(DAYOFYEAR, '1994-12-27');
SELECT DATENAME(WEEKDAY, '1994-12-27');

-- Extract different components of a date using DATEPART
SELECT DATEPART(YEAR, '1994-12-27');       -- Returns the year component: 1994
SELECT DATEPART(MONTH, '1994-12-27');      -- Returns the month component: 12
SELECT DATEPART(WEEK, '1994-12-27');       -- Returns the ISO week number: 53
SELECT DATEPART(DAY, '1994-12-27');        -- Returns the day of the month: 27
SELECT DATEPART(DAYOFYEAR, '1994-12-27');  -- Returns the day of the year: 361
SELECT DATEPART(WEEKDAY, '1994-12-27');    -- Returns the weekday index: 3

-- Extract basic components using built-in functions
SELECT YEAR('1994-12-27');  -- Returns: 1994
SELECT MONTH('1994-12-27'); -- Returns: 12
SELECT DAY('1994-12-27');   -- Returns: 27


--------------------------------------------
-- Assignment 7

-- Calculate date differences
SELECT DATEDIFF(YEAR, '2018-7-16', '2025-7-16');   -- Years between
SELECT DATEDIFF(YEAR, '2018-7-16', GETDATE());     -- Years until today
SELECT DATEDIFF(MONTH, '2018-7-16', '2025-7-16');  -- Months between
SELECT DATEDIFF(WEEK, '2018-7-16', '2025-7-16');   -- Weeks between
SELECT DATEDIFF(DAY, '2018-7-16', '2025-7-16');    -- Days between

-- Add time intervals to a specific date
SELECT DATEADD(YEAR, 5, '2018-7-16');
SELECT DATEADD(MONTH, 5, '2018-7-16');
SELECT DATEADD(WEEK, 5, '2018-7-16');
SELECT DATEADD(DAY, 5, '2018-7-16');


--------------------------------------------
-- Task 7

-- 2) User-defined Functions:
-- 2.1 Scalar-valued Function
CREATE FUNCTION CalculatePrice(@cost DECIMAL(18,2), @profitRatio DECIMAL(18,2))
RETURNS DECIMAL(18,2)
BEGIN
    RETURN @cost + @cost * @profitRatio;
END

-- Invoke the function directly
SELECT dbo.CalculatePrice(1000, 0.35);
-- Invoke the function with alias
SELECT dbo.CalculatePrice(1000, 0.35) AS 'Net Price';
