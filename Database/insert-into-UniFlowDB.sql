
-----------------------------------------------
--- This is a script to insert sample data. ---
--- Run it once to avoid duplicates.        ---
-----------------------------------------------

USE UniFLow;
GO

-- Insert into academic_statuses
INSERT INTO academic_statuses (status_name, description)
VALUES 
('Active', 'Student is currently active and enrolled'),
('Probation', 'Student is on academic probation'),
('Suspended', 'Student is temporarily suspended'),
('Graduated', 'Student has completed all requirements'),
('Withdrawn', 'Student has withdrawn from the university');

-- Insert into permissions
INSERT INTO permissions (permission_key, description)
VALUES
('admin.access', 'Full administrative access'),
('student.view', 'View student records'),
('student.edit', 'Edit student records'),
('course.manage', 'Manage course offerings'),
('grades.submit', 'Submit student grades');

-- Insert into roles
INSERT INTO roles (role_name, description)
VALUES
('Administrator', 'System administrator with full access'),
('Professor', 'Teaching faculty member'),
('Student', 'Enrolled student'),
('Staff', 'Administrative staff'),
('Advisor', 'Academic advisor');

-- Insert into role_permissions
INSERT INTO role_permissions (role_id, permission_id)
VALUES
(1, 1), (1, 2), (1, 3), (1, 4), (1, 5),  -- Admin has all permissions
(2, 2), (2, 4), (2, 5),                   -- Professor can view students, manage courses, submit grades
(3, 2),                                     -- Student can view their own records
(4, 2), (4, 3),                             -- Staff can view and edit student records
(5, 2), (5, 3);                             -- Advisor can view and edit student records

-- Insert into people (15 Arab names in English)
INSERT INTO people (first_name, last_name, date_of_birth, gender, phone, address, national_id, image_path)
VALUES
('Mohammed', 'Al-Mansour', '1990-05-15', 'M', '966501234567', '123 King Fahd Road, Riyadh', '1000000001', '/images/mohammed.jpg'),
('Fatima', 'Al-Ghamdi', '1992-08-20', 'F', '966502345678', '456 Prince Sultan St, Jeddah', '1000000002', '/images/fatima.jpg'),
('Ahmed', 'Al-Saud', '1985-11-03', 'M', '966503456789', '789 King Abdullah Road, Dammam', '1000000003', '/images/ahmed.jpg'),
('Layla', 'Al-Hashimi', '1993-02-28', 'F', '966504567890', '321 Corniche Road, Khobar', '1000000004', '/images/layla.jpg'),
('Omar', 'Al-Qurashi', '1988-07-12', 'M', '966505678901', '654 University St, Medina', '1000000005', '/images/omar.jpg'),
('Aisha', 'Al-Zahrani', '1995-04-05', 'F', '966506789012', '987 King Faisal Road, Taif', '1000000006', '/images/aisha.jpg'),
('Khalid', 'Al-Otaibi', '1987-09-18', 'M', '966507890123', '159 Prince Mohammed St, Abha', '1000000007', '/images/khalid.jpg'),
('Noura', 'Al-Juhani', '1991-12-25', 'F', '966508901234', '753 King Khalid Road, Buraidah', '1000000008', '/images/noura.jpg'),
('Yousef', 'Al-Shammari', '1989-06-30', 'M', '966509012345', '852 Prince Turki St, Hail', '1000000009', '/images/yousef.jpg'),
('Huda', 'Al-Nasser', '1994-03-14', 'F', '966510123456', '456 King Saud Road, Tabuk', '1000000010', '/images/huda.jpg'),
('Abdullah', 'Al-Dossary', '1986-10-22', 'M', '966511234567', '789 Prince Naif St, Jazan', '1000000011', '/images/abdullah.jpg'),
('Maha', 'Al-Balawi', '1996-01-07', 'F', '966512345678', '123 King Abdulaziz Road, Najran', '1000000012', '/images/maha.jpg'),
('Faisal', 'Al-Harbi', '1984-08-11', 'M', '966513456789', '456 Prince Fahd St, Arar', '1000000013', '/images/faisal.jpg'),
('Samira', 'Al-Tamimi', '1997-05-19', 'F', '966514567890', '789 King Fahd Road, Qassim', '1000000014', '/images/samira.jpg'),
('Ibrahim', 'Al-Ghamdi', '1983-12-31', 'M', '966515678901', '123 Prince Sultan St, Hafr Al-Batin', '1000000015', '/images/ibrahim.jpg');

-- Insert into departments
INSERT INTO departments (name, code, building, budget, head_instructor_id)
VALUES
('Computer Science', 'CS', 'Engineering', 5000000.00, NULL),
('Business Administration', 'BUS', 'Business', 4500000.00, NULL),
('Electrical Engineering', 'EE', 'Engineering', 4800000.00, NULL),
('Medicine', 'MED', 'Medical', 6000000.00, NULL),
('Islamic Studies', 'ISL', 'Humanities', 3500000.00, NULL);

-- Insert into instructors (update department heads later)
INSERT INTO instructors (person_id, title, department_id, hire_date, office_location, is_active)
VALUES
(3, 'Professor', 1, '2010-09-01', 'ENG-205', 1),
(7, 'Associate Professor', 2, '2012-03-15', 'BUS-110', 1),
(13, 'Assistant Professor', 3, '2015-08-20', 'ENG-310', 1),
(5, 'Professor', 4, '2008-11-01', 'MED-420', 1),
(9, 'Lecturer', 5, '2018-02-10', 'HUM-105', 1);

-- Update department heads
UPDATE departments SET head_instructor_id = 1 WHERE department_id = 1;
UPDATE departments SET head_instructor_id = 2 WHERE department_id = 2;
UPDATE departments SET head_instructor_id = 3 WHERE department_id = 3;
UPDATE departments SET head_instructor_id = 4 WHERE department_id = 4;
UPDATE departments SET head_instructor_id = 5 WHERE department_id = 5;

-- Insert into staff
INSERT INTO staff (person_id, position, department_id, hire_date, is_active)
VALUES
(15, 'Administrative Assistant', 1, '2019-05-15', 1),
(12, 'IT Support Specialist', 3, '2017-11-20', 1),
(8, 'Registrar Officer', 2, '2016-07-10', 1),
(4, 'Lab Technician', 4, '2020-01-05', 1),
(10, 'Library Assistant', 5, '2018-09-30', 1);

-- Insert into students
INSERT INTO students (person_id, student_number, major_department_id, admission_date, expected_graduation, current_gpa, academic_status_id)
VALUES
(2, 'S2023001', 1, '2023-09-01', '2027-06-01', 3.75, 1),
(6, 'S2023002', 2, '2023-09-01', '2027-06-01', 3.20, 1),
(11, 'S2022001', 3, '2022-09-01', '2026-06-01', 2.85, 2),
(14, 'S2021001', 4, '2021-09-01', '2025-06-01', 3.90, 1),
(1, 'S2020001', 5, '2020-09-01', '2024-06-01', 3.50, 1);

-- Insert into users
INSERT INTO users (person_id, role_id, username, password_hash, email, is_active, last_login, account_created)
VALUES
(3, 1, 'admin1', '$2a$10$xJwL5v5Jz5U5Z5U5Z5U5Ze', 'admin1@uniflow.edu', 1, GETDATE(), '2020-01-15'),
(7, 2, 'prof1', '$2a$10$xJwL5v5Jz5U5Z5U5Z5U5Ze', 'prof1@uniflow.edu', 1, GETDATE(), '2021-03-20'),
(13, 2, 'prof2', '$2a$10$xJwL5v5Jz5U5Z5U5Z5U5Ze', 'prof2@uniflow.edu', 1, GETDATE(), '2021-08-25'),
(2, 3, 'student1', '$2a$10$xJwL5v5Jz5U5Z5U5Z5U5Ze', 'student1@uniflow.edu', 1, GETDATE(), '2023-09-01'),
(15, 4, 'staff1', '$2a$10$xJwL5v5Jz5U5Z5U5Z5U5Ze', 'staff1@uniflow.edu', 1, GETDATE(), '2019-05-20');

-- Insert into courses
INSERT INTO courses (department_id, code, title, description, credits)
VALUES
(1, 'CS101', 'Introduction to Programming', 'Fundamentals of computer programming', 4),
(1, 'CS201', 'Data Structures', 'Study of common data structures and algorithms', 4),
(2, 'BUS101', 'Principles of Management', 'Introduction to business management', 3),
(3, 'EE201', 'Circuit Theory', 'Fundamentals of electrical circuits', 4),
(5, 'ISL101', 'Islamic History', 'Survey of Islamic civilization', 3);

-- Insert into prerequisites
INSERT INTO prerequisites (course_id, required_course_id, minimum_grade)
VALUES
(2, 1, 'C+'),
(4, 1, 'C');

-- Insert into semesters
INSERT INTO semesters (name, year, start_date, end_date, registration_deadline)
VALUES
('Fall', 2023, '2023-09-01', '2023-12-20', '2023-08-15'),
('Spring', 2024, '2024-01-15', '2024-05-10', '2023-12-01'),
('Summer', 2023, '2023-06-01', '2023-08-15', '2023-05-15'),
('Fall', 2022, '2022-09-01', '2022-12-20', '2022-08-15'),
('Spring', 2023, '2023-01-15', '2023-05-10', '2022-12-01');

-- Insert into offerings
INSERT INTO offerings (course_id, semester_id, instructor_id, classroom, schedule, capacity, current_enrollment)
VALUES
(1, 1, 1, 'CS-101', 'MWF 10:00-11:00', 30, 25),
(2, 1, 1, 'CS-201', 'TTH 13:00-14:30', 25, 20),
(3, 2, 2, 'BUS-105', 'MW 11:00-12:30', 40, 35),
(4, 2, 3, 'EE-210', 'TTH 09:00-10:30', 20, 18),
(5, 3, 5, 'HUM-110', 'MWF 14:00-15:00', 35, 30);

-- Insert into enrollments
INSERT INTO enrollments (student_id, offering_id, enrollment_date, academic_status_id, final_grade)
VALUES
(1, 1, '2023-09-01', 1, 'A'),
(2, 1, '2023-09-01', 1, 'B+'),
(3, 2, '2023-09-02', 1, 'A-'),
(4, 3, '2023-09-01', 1, 'B'),
(5, 4, '2023-09-03', 1, 'A');


-- Select Tables:
SELECT * FROM [people];
SELECT * FROM [academic_statuses];
SELECT * FROM [permissions];
SELECT * FROM [roles];
SELECT * FROM [role_permissions];
SELECT * FROM [users];
SELECT * FROM [departments];
SELECT * FROM [instructors];
SELECT * FROM [staff];
SELECT * FROM [students];
SELECT * FROM [courses];
SELECT * FROM [prerequisites];
SELECT * FROM [semesters];
SELECT * FROM [offerings];
SELECT * FROM [enrollments];
