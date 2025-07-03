USE UniFlow;
GO

-- 1. People table
SELECT 
    person_id AS 'ID',
    first_name AS 'First Name',
    last_name AS 'Last Name',
    CONVERT(VARCHAR(10), date_of_birth, 120) AS 'Birth Date',
    gender AS 'Gender',
    phone AS 'Phone',
    address AS 'Address',
    national_id AS 'National ID'
FROM people
ORDER BY last_name, first_name;

-- 2. Academic Statuses
SELECT 
    statuses_id AS 'Status ID',
    status_name AS 'Status',
    description AS 'Description'
FROM academic_statuses
ORDER BY statuses_id;

-- 3. Permissions
SELECT 
    permission_id AS 'Permission ID',
    permission_key AS 'Key',
    description AS 'Description'
FROM permissions
ORDER BY permission_id;

-- 4. Roles
SELECT 
    role_id AS 'Role ID',
    role_name AS 'Role',
    description AS 'Description'
FROM roles
ORDER BY role_id;

-- 5. Role Permissions
SELECT 
    rp.role_id AS 'Role ID',
    r.role_name AS 'Role',
    rp.permission_id AS 'Permission ID',
    p.permission_key AS 'Permission'
FROM role_permissions rp
JOIN roles r ON rp.role_id = r.role_id
JOIN permissions p ON rp.permission_id = p.permission_id
ORDER BY r.role_name, p.permission_key;

-- 6. Users
SELECT 
    u.user_id AS 'User ID',
    p.first_name + ' ' + p.last_name AS 'Name',
    r.role_name AS 'Role',
    u.username AS 'Username',
    u.email AS 'Email',
    CASE u.is_active WHEN 1 THEN 'Yes' ELSE 'No' END AS 'Active',
    CONVERT(VARCHAR(20), u.last_login, 120) AS 'Last Login'
FROM users u
JOIN people p ON u.person_id = p.person_id
JOIN roles r ON u.role_id = r.role_id
ORDER BY r.role_name, p.last_name;

-- 7. Departments
SELECT 
    d.department_id AS 'Dept ID',
    d.name AS 'Department',
    d.code AS 'Code',
    d.building AS 'Building',
    FORMAT(d.budget, 'C') AS 'Budget',
    i.first_name + ' ' + i.last_name AS 'Department Head'
FROM departments d
LEFT JOIN instructors ins ON d.head_instructor_id = ins.instructor_id
LEFT JOIN people i ON ins.person_id = i.person_id
ORDER BY d.name;

-- 8. Instructors
SELECT 
    i.instructor_id AS 'Instructor ID',
    p.first_name + ' ' + p.last_name AS 'Name',
    i.title AS 'Title',
    d.name AS 'Department',
    CONVERT(VARCHAR(10), i.hire_date, 120) AS 'Hire Date',
    i.office_location AS 'Office',
    CASE i.is_active WHEN 1 THEN 'Yes' ELSE 'No' END AS 'Active'
FROM instructors i
JOIN people p ON i.person_id = p.person_id
JOIN departments d ON i.department_id = d.department_id
ORDER BY d.name, p.last_name;

-- 9. Staff
SELECT 
    s.staff_id AS 'Staff ID',
    p.first_name + ' ' + p.last_name AS 'Name',
    s.position AS 'Position',
    d.name AS 'Department',
    CONVERT(VARCHAR(10), s.hire_date, 120) AS 'Hire Date',
    CASE s.is_active WHEN 1 THEN 'Yes' ELSE 'No' END AS 'Active'
FROM staff s
JOIN people p ON s.person_id = p.person_id
JOIN departments d ON s.department_id = d.department_id
ORDER BY d.name, p.last_name;

-- 10. Students
SELECT 
    s.student_id AS 'Student ID',
    p.first_name + ' ' + p.last_name AS 'Name',
    s.student_number AS 'Student No',
    d.name AS 'Major',
    CONVERT(VARCHAR(10), s.admission_date, 120) AS 'Admission Date',
    CONVERT(VARCHAR(10), s.expected_graduation, 120) AS 'Expected Grad',
    s.current_gpa AS 'GPA',
    ast.status_name AS 'Status'
FROM students s
JOIN people p ON s.person_id = p.person_id
JOIN departments d ON s.major_department_id = d.department_id
JOIN academic_statuses ast ON s.academic_status_id = ast.statuses_id
ORDER BY d.name, p.last_name;

-- 11. Courses
SELECT 
    c.course_id AS 'Course ID',
    c.code AS 'Code',
    c.title AS 'Title',
    d.name AS 'Department',
    c.credits AS 'Credits'
FROM courses c
JOIN departments d ON c.department_id = d.department_id
ORDER BY d.name, c.code;

-- 12. Prerequisites
SELECT 
    pr.prerequisite_id AS 'Prereq ID',
    c1.code + ' - ' + c1.title AS 'Course',
    c2.code + ' - ' + c2.title AS 'Requires',
    pr.minimum_grade AS 'Min Grade'
FROM prerequisites pr
JOIN courses c1 ON pr.course_id = c1.course_id
JOIN courses c2 ON pr.required_course_id = c2.course_id
ORDER BY c1.code, c2.code;

-- 13. Semesters
SELECT 
    semester_id AS 'Semester ID',
    name + ' ' + CAST(year AS VARCHAR) AS 'Semester',
    CONVERT(VARCHAR(10), start_date, 120) AS 'Start Date',
    CONVERT(VARCHAR(10), end_date, 120) AS 'End Date',
    CONVERT(VARCHAR(10), registration_deadline, 120) AS 'Reg Deadline'
FROM semesters
ORDER BY year, 
    CASE name 
        WHEN 'Spring' THEN 1 
        WHEN 'Summer' THEN 2 
        WHEN 'Fall' THEN 3 
        ELSE 4 
    END;

-- 14. Offerings
SELECT 
    o.offering_id AS 'Offering ID',
    c.code + ' - ' + c.title AS 'Course',
    s.name + ' ' + CAST(s.year AS VARCHAR) AS 'Semester',
    p.first_name + ' ' + p.last_name AS 'Instructor',
    o.classroom AS 'Room',
    o.schedule AS 'Schedule',
    o.current_enrollment AS 'Enrolled',
    o.capacity AS 'Capacity'
FROM offerings o
JOIN courses c ON o.course_id = c.course_id
JOIN semesters s ON o.semester_id = s.semester_id
JOIN instructors i ON o.instructor_id = i.instructor_id
JOIN people p ON i.person_id = p.person_id
ORDER BY s.year, s.name, c.code;

-- 15. Enrollments
SELECT 
    e.enrollment_id AS 'Enrollment ID',
    p.first_name + ' ' + p.last_name AS 'Student',
    c.code + ' - ' + c.title AS 'Course',
    s.name + ' ' + CAST(s.year AS VARCHAR) AS 'Semester',
    CONVERT(VARCHAR(10), e.enrollment_date, 120) AS 'Enrollment Date',
    e.final_grade AS 'Grade',
    ast.status_name AS 'Status'
FROM enrollments e
JOIN students st ON e.student_id = st.student_id
JOIN people p ON st.person_id = p.person_id
JOIN offerings o ON e.offering_id = o.offering_id
JOIN courses c ON o.course_id = c.course_id
JOIN semesters s ON o.semester_id = s.semester_id
JOIN academic_statuses ast ON e.academic_status_id = ast.statuses_id
ORDER BY s.year DESC, s.name, c.code, p.last_name;