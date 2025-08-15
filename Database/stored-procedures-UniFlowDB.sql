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


-- 6. Get all users
CREATE OR ALTER PROCEDURE usp_GetAllUsers
AS
BEGIN
    SELECT 
        u.user_id,
        u.person_id,
        u.role_id,
        u.username,
        u.password_hash,
        u.email,
        u.is_active,
        u.last_login,
        u.account_created,
        p.first_name,
        p.last_name,
        r.role_name
    FROM users u
    JOIN people p ON u.person_id = p.person_id
    JOIN roles r ON u.role_id = r.role_id
    ORDER BY u.username;
END;
GO

-- 7. Get user by ID
CREATE OR ALTER PROCEDURE usp_GetUserById
    @UserId INT
AS
BEGIN
    SELECT 
        u.user_id,
        u.person_id,
        u.role_id,
        u.username,
        u.password_hash,
        u.email,
        u.is_active,
        u.last_login,
        u.account_created,
        p.first_name,
        p.last_name,
        r.role_name
    FROM users u
    JOIN people p ON u.person_id = p.person_id
    JOIN roles r ON u.role_id = r.role_id
    WHERE u.user_id = @UserId;
END;
GO

-- 8. Get user by username
CREATE OR ALTER PROCEDURE usp_GetUserByUsername
    @Username VARCHAR(50)
AS
BEGIN
    SELECT 
        u.user_id,
        u.person_id,
        u.role_id,
        u.username,
        u.password_hash,
        u.email,
        u.is_active,
        u.last_login,
        u.account_created,
        p.first_name,
        p.last_name,
        r.role_name
    FROM users u
    JOIN people p ON u.person_id = p.person_id
    JOIN roles r ON u.role_id = r.role_id
    WHERE u.username = @Username;
END;
GO

-- 9. Add new user
CREATE OR ALTER PROCEDURE usp_AddUser
    @PersonId INT,
    @RoleId INT,
    @Username VARCHAR(50),
    @PasswordHash VARCHAR(255),
    @Email VARCHAR(100),
    @IsActive BIT = 1,
    @NewUserId INT OUTPUT
AS
BEGIN
    INSERT INTO users (
        person_id,
        role_id,
        username,
        password_hash,
        email,
        is_active,
        account_created
    )
    VALUES (
        @PersonId,
        @RoleId,
        @Username,
        @PasswordHash,
        @Email,
        @IsActive,
        GETDATE()
    );
    
    SET @NewUserId = SCOPE_IDENTITY();
END;
GO

-- 10. Update user
CREATE OR ALTER PROCEDURE usp_UpdateUser
    @UserId INT,
    @PersonId INT,
    @RoleId INT,
    @Username VARCHAR(50),
    @Email VARCHAR(100),
    @IsActive BIT
AS
BEGIN
    UPDATE users
    SET 
        person_id = @PersonId,
        role_id = @RoleId,
        username = @Username,
        email = @Email,
        is_active = @IsActive
    WHERE user_id = @UserId;
    
    IF @@ROWCOUNT = 0
        RAISERROR('No user found with ID %d', 16, 1, @UserId);
END;
GO

-- 11. Update user password
CREATE OR ALTER PROCEDURE usp_UpdateUserPassword
    @UserId INT,
    @PasswordHash VARCHAR(255)
AS
BEGIN
    UPDATE users
    SET password_hash = @PasswordHash
    WHERE user_id = @UserId;
    
    IF @@ROWCOUNT = 0
        RAISERROR('No user found with ID %d', 16, 1, @UserId);
END;
GO

-- 12. Update user last login
CREATE OR ALTER PROCEDURE usp_UpdateUserLastLogin
    @UserId INT
AS
BEGIN
    UPDATE users
    SET last_login = GETDATE()
    WHERE user_id = @UserId;
    
    IF @@ROWCOUNT = 0
        RAISERROR('No user found with ID %d', 16, 1, @UserId);
END;
GO

-- 13. Activate/Deactivate user
CREATE OR ALTER PROCEDURE usp_SetUserActiveStatus
    @UserId INT,
    @IsActive BIT
AS
BEGIN
    UPDATE users
    SET is_active = @IsActive
    WHERE user_id = @UserId;
    
    IF @@ROWCOUNT = 0
        RAISERROR('No user found with ID %d', 16, 1, @UserId);
END;
GO

-- 14. Delete user
CREATE OR ALTER PROCEDURE usp_DeleteUser
    @UserId INT
AS
BEGIN
    DELETE FROM users
    WHERE user_id = @UserId;
    
    IF @@ROWCOUNT = 0
        RAISERROR('No user found with ID %d', 16, 1, @UserId);
END;
GO