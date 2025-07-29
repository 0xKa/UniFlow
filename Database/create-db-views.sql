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
