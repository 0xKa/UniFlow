use UniFlow;
GO

-- people view
CREATE or alter VIEW [vw_people]
AS
    SELECT 
        p.person_id as PersonID,
		p.national_id as NationalID, 
        p.first_name + ' ' + p.last_name as FullName,
        CASE 
			WHEN p.gender = 'M' THEN 'Male'
			WHEN p.gender = 'F' THEN 'Female'
			END AS Gender,
        p.date_of_birth as DateOfBirth,
		DATEDIFF(YEAR, p.date_of_birth, GETDATE()) - 
        CASE 
            WHEN DATEADD(YEAR, DATEDIFF(YEAR, p.date_of_birth, GETDATE()), p.date_of_birth) > GETDATE() 
            THEN 1 
            ELSE 0 
        END AS Age,     
		p.phone
    FROM 
        People p
GO

select * from vw_people;
go


-- User View
CREATE OR ALTER VIEW vw_Users
AS
SELECT 
    u.user_id,
    u.person_id,
	p.FullName,
    u.role_id,
	r.role_name,
    u.username,
    u.email,
    u.is_active,
    u.last_login,
    u.account_created
FROM users u
    INNER JOIN vw_people p ON u.person_id = p.PersonID
    INNER JOIN roles r ON u.role_id = r.role_id;
GO

SELECT * FROM vw_Users;