USE UniFLow;
GO

-- 1. Get all people
CREATE OR ALTER PROCEDURE usp_GetAllPeople
AS
BEGIN
    SELECT 
        person_id,
        first_name,
        last_name,
        date_of_birth,
        gender,
        phone,
        address,
        national_id,
        image_path
    FROM people
END;
GO

-- 2. Get person by ID
CREATE OR ALTER PROCEDURE usp_GetPersonById
    @PersonId INT
AS
BEGIN
    SELECT 
        person_id,
        first_name,
        last_name,
        date_of_birth,
        gender,
        phone,
        address,
        national_id,
        image_path
    FROM people
    WHERE person_id = @PersonId;
END;
GO

-- 3. Add new person
CREATE OR ALTER PROCEDURE usp_AddPerson
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @DateOfBirth DATE,
    @Gender CHAR(1),
    @Phone VARCHAR(20),
    @Address NVARCHAR(200) = NULL,
    @NationalId VARCHAR(50),
    @ImagePath VARCHAR(500),
    @NewPersonId INT OUTPUT
AS
BEGIN
    INSERT INTO people (
        first_name,
        last_name,
        date_of_birth,
        gender,
        phone,
        address,
        national_id,
        image_path
    )
    VALUES (
        @FirstName,
        @LastName,
        @DateOfBirth,
        @Gender,
        @Phone,
        @Address,
        @NationalId,
        @ImagePath
    );
    
    SET @NewPersonId = SCOPE_IDENTITY();
END;
GO

-- 4. Update person
CREATE OR ALTER PROCEDURE usp_UpdatePerson
    @PersonId INT,
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @DateOfBirth DATE,
    @Gender CHAR(1),
    @Phone VARCHAR(20),
    @Address NVARCHAR(200) = NULL,
    @NationalId VARCHAR(50),
    @ImagePath VARCHAR(500) = NULL
AS
BEGIN
    UPDATE people
    SET 
        first_name = @FirstName,
        last_name = @LastName,
        date_of_birth = @DateOfBirth,
        gender = @Gender,
        phone = @Phone,
        address = @Address,
        national_id = @NationalId,
        image_path = @ImagePath
    WHERE person_id = @PersonId;
    
    IF @@ROWCOUNT = 0
        RAISERROR('No person found with ID %d', 16, 1, @PersonId);
END;
GO

-- 5. Delete person
CREATE OR ALTER PROCEDURE usp_DeletePerson
    @PersonId INT
AS
BEGIN
    DELETE FROM people
    WHERE person_id = @PersonId;
END;
GO
