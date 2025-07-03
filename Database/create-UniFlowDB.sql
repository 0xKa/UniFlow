------------------------------------------------------
--- This is a script to create UniFlow DB Tables.  ---
------------------------------------------------------

CREATE DATABASE UniFlow;
GO

USE UniFlow;
GO

CREATE TABLE "people"(
    "person_id" INT IDENTITY(1,1) NOT NULL,
    "first_name" NVARCHAR(50) NOT NULL,
    "last_name" NVARCHAR(50) NOT NULL,
    "date_of_birth" DATE NOT NULL,
    "gender" CHAR(1) NOT NULL,
    "phone" VARCHAR(20) NOT NULL,
    "address" NVARCHAR(200) NULL,
    "national_id" VARCHAR(50) NOT NULL,
    "image_path" VARCHAR(500) NOT NULL
);
ALTER TABLE
    "people" ADD CONSTRAINT "people_person_id_primary" PRIMARY KEY("person_id");
CREATE UNIQUE INDEX "people_national_id_unique" ON
    "people"("national_id");

CREATE TABLE "academic_statuses"(
    "statuses_id" INT IDENTITY(1,1) NOT NULL,
    "status_name" VARCHAR(30) NOT NULL,
    "description" VARCHAR(200) NOT NULL
);
ALTER TABLE
    "academic_statuses" ADD CONSTRAINT "academic_statuses_statuses_id_primary" PRIMARY KEY("statuses_id");

CREATE TABLE "permissions"(
    "permission_id" INT IDENTITY(1,1) NOT NULL,
    "permission_key" VARCHAR(50) NOT NULL,
    "description" VARCHAR(200) NULL
);
ALTER TABLE
    "permissions" ADD CONSTRAINT "permissions_permission_id_primary" PRIMARY KEY("permission_id");
CREATE UNIQUE INDEX "permissions_permission_key_unique" ON
    "permissions"("permission_key");

CREATE TABLE "roles"(
    "role_id" INT IDENTITY(1,1) NOT NULL,
    "role_name" VARCHAR(50) NOT NULL,
    "description" VARCHAR(200) NULL
);
ALTER TABLE
    "roles" ADD CONSTRAINT "roles_role_id_primary" PRIMARY KEY("role_id");

CREATE TABLE "role_permissions"(
    "role_id" INT NOT NULL,
    "permission_id" INT NOT NULL
);
ALTER TABLE "role_permissions" ADD CONSTRAINT "role_permissions_pk" 
    PRIMARY KEY ("role_id", "permission_id");

CREATE TABLE "users"(
    "user_id" INT IDENTITY(1,1) NOT NULL,
    "person_id" INT NOT NULL,
    "role_id" INT NOT NULL,
    "username" VARCHAR(50) NOT NULL,
    "password_hash" VARCHAR(255) NOT NULL,
    "email" VARCHAR(100) NOT NULL,
    "is_active" BIT NOT NULL,
    "last_login" DATETIME2 NULL,
    "account_created" DATETIME2 NOT NULL
);
ALTER TABLE
    "users" ADD CONSTRAINT "users_user_id_primary" PRIMARY KEY("user_id");
CREATE UNIQUE INDEX "users_username_unique" ON
    "users"("username");

CREATE TABLE "departments"(
    "department_id" INT IDENTITY(1,1) NOT NULL,
    "name" VARCHAR(100) NOT NULL,
    "code" VARCHAR(10) NOT NULL,
    "building" VARCHAR(50) NULL,
    "budget" DECIMAL(12, 2) NULL,
    "head_instructor_id" INT NULL
);
ALTER TABLE
    "departments" ADD CONSTRAINT "departments_department_id_primary" PRIMARY KEY("department_id");
CREATE UNIQUE INDEX "departments_code_unique" ON
    "departments"("code");

CREATE TABLE "instructors"(
    "instructor_id" INT IDENTITY(1,1) NOT NULL,
    "person_id" INT NOT NULL,
    "title" VARCHAR(50) NOT NULL,
    "department_id" INT NOT NULL,
    "hire_date" DATE NOT NULL,
    "office_location" VARCHAR(50) NULL,
    "is_active" BIT NOT NULL
);
ALTER TABLE
    "instructors" ADD CONSTRAINT "instructors_instructor_id_primary" PRIMARY KEY("instructor_id");

CREATE TABLE "staff"(
    "staff_id" INT IDENTITY(1,1) NOT NULL,
    "person_id" INT NOT NULL,
    "position" VARCHAR(255) NOT NULL,
    "department_id" INT NOT NULL,
    "hire_date" DATE NOT NULL,
    "is_active" BIT NOT NULL
);
ALTER TABLE
    "staff" ADD CONSTRAINT "staff_staff_id_primary" PRIMARY KEY("staff_id");

CREATE TABLE "students"(
    "student_id" INT IDENTITY(1,1) NOT NULL,
    "person_id" INT NOT NULL,
    "student_number" VARCHAR(20) NOT NULL,
    "major_department_id" INT NOT NULL,
    "admission_date" DATE NOT NULL,
    "expected_graduation" DATE NULL,
    "current_gpa" DECIMAL(3, 2) NULL,
    "academic_status_id" INT NOT NULL
);
ALTER TABLE
    "students" ADD CONSTRAINT "students_student_id_primary" PRIMARY KEY("student_id");
CREATE UNIQUE INDEX "students_student_number_unique" ON
    "students"("student_number");

CREATE TABLE "courses"(
    "course_id" INT IDENTITY(1,1) NOT NULL,
    "department_id" INT NOT NULL,
    "code" VARCHAR(20) NOT NULL,
    "title" VARCHAR(100) NOT NULL,
    "description" VARCHAR(999) NULL,
    "credits" INT NOT NULL
);
ALTER TABLE
    "courses" ADD CONSTRAINT "courses_course_id_primary" PRIMARY KEY("course_id");
CREATE UNIQUE INDEX "courses_code_unique" ON
    "courses"("code");

CREATE TABLE "prerequisites"(
    "prerequisite_id" INT IDENTITY(1,1) NOT NULL,
    "course_id" INT NOT NULL,
    "required_course_id" INT NOT NULL,
    "minimum_grade" CHAR(2) NULL
);
ALTER TABLE
    "prerequisites" ADD CONSTRAINT "prerequisites_prerequisite_id_primary" PRIMARY KEY("prerequisite_id");

CREATE TABLE "semesters"(
    "semester_id" INT IDENTITY(1,1) NOT NULL,
    "name" VARCHAR(20) NOT NULL,
    "year" INT NOT NULL,
    "start_date" DATE NOT NULL,
    "end_date" DATE NOT NULL,
    "registration_deadline" DATE NULL
);
ALTER TABLE
    "semesters" ADD CONSTRAINT "semesters_semester_id_primary" PRIMARY KEY("semester_id");

CREATE TABLE "offerings"(
    "offering_id" INT IDENTITY(1,1) NOT NULL,
    "course_id" INT NOT NULL,
    "semester_id" INT NOT NULL,
    "instructor_id" INT NOT NULL,
    "classroom" VARCHAR(20) NULL,
    "schedule" VARCHAR(100) NULL,
    "capacity" INT NOT NULL,
    "current_enrollment" INT NOT NULL
);
ALTER TABLE
    "offerings" ADD CONSTRAINT "offerings_offering_id_primary" PRIMARY KEY("offering_id");

CREATE TABLE "enrollments"(
    "enrollment_id" INT IDENTITY(1,1) NOT NULL,
    "student_id" INT NOT NULL,
    "offering_id" INT NOT NULL,
    "enrollment_date" DATETIME2 NOT NULL,
    "academic_status_id" INT NOT NULL,
    "final_grade" CHAR(2) NULL
);
ALTER TABLE
    "enrollments" ADD CONSTRAINT "enrollments_enrollment_id_primary" PRIMARY KEY("enrollment_id");

-- Foreign key constraints
ALTER TABLE
    "users" ADD CONSTRAINT "users_person_id_foreign" FOREIGN KEY("person_id") REFERENCES "people"("person_id");
ALTER TABLE
    "users" ADD CONSTRAINT "users_role_id_foreign" FOREIGN KEY("role_id") REFERENCES "roles"("role_id");
    
ALTER TABLE
    "role_permissions" ADD CONSTRAINT "role_permissions_role_id_foreign" FOREIGN KEY("role_id") REFERENCES "roles"("role_id");
ALTER TABLE
    "role_permissions" ADD CONSTRAINT "role_permissions_permission_id_foreign" FOREIGN KEY("permission_id") REFERENCES "permissions"("permission_id");
    
ALTER TABLE
    "instructors" ADD CONSTRAINT "instructors_person_id_foreign" FOREIGN KEY("person_id") REFERENCES "people"("person_id");
ALTER TABLE
    "instructors" ADD CONSTRAINT "instructors_department_id_foreign" FOREIGN KEY("department_id") REFERENCES "departments"("department_id");
    
ALTER TABLE
    "departments" ADD CONSTRAINT "departments_head_instructor_id_foreign" FOREIGN KEY("head_instructor_id") REFERENCES "instructors"("instructor_id");
    
ALTER TABLE
    "staff" ADD CONSTRAINT "staff_person_id_foreign" FOREIGN KEY("person_id") REFERENCES "people"("person_id");
ALTER TABLE
    "staff" ADD CONSTRAINT "staff_department_id_foreign" FOREIGN KEY("department_id") REFERENCES "departments"("department_id");
    
ALTER TABLE
    "students" ADD CONSTRAINT "students_person_id_foreign" FOREIGN KEY("person_id") REFERENCES "people"("person_id");
ALTER TABLE
    "students" ADD CONSTRAINT "students_major_department_id_foreign" FOREIGN KEY("major_department_id") REFERENCES "departments"("department_id");
ALTER TABLE
    "students" ADD CONSTRAINT "students_academic_status_id_foreign" FOREIGN KEY("academic_status_id") REFERENCES "academic_statuses"("statuses_id");
    
ALTER TABLE
    "courses" ADD CONSTRAINT "courses_department_id_foreign" FOREIGN KEY("department_id") REFERENCES "departments"("department_id");
    
ALTER TABLE
    "prerequisites" ADD CONSTRAINT "prerequisites_course_id_foreign" FOREIGN KEY("course_id") REFERENCES "courses"("course_id");
ALTER TABLE
    "prerequisites" ADD CONSTRAINT "prerequisites_required_course_id_foreign" FOREIGN KEY("required_course_id") REFERENCES "courses"("course_id");
    
ALTER TABLE
    "offerings" ADD CONSTRAINT "offerings_course_id_foreign" FOREIGN KEY("course_id") REFERENCES "courses"("course_id");
ALTER TABLE
    "offerings" ADD CONSTRAINT "offerings_semester_id_foreign" FOREIGN KEY("semester_id") REFERENCES "semesters"("semester_id");
ALTER TABLE
    "offerings" ADD CONSTRAINT "offerings_instructor_id_foreign" FOREIGN KEY("instructor_id") REFERENCES "instructors"("instructor_id");
    
ALTER TABLE
    "enrollments" ADD CONSTRAINT "enrollments_student_id_foreign" FOREIGN KEY("student_id") REFERENCES "students"("student_id");
ALTER TABLE
    "enrollments" ADD CONSTRAINT "enrollments_offering_id_foreign" FOREIGN KEY("offering_id") REFERENCES "offerings"("offering_id");
ALTER TABLE
    "enrollments" ADD CONSTRAINT "enrollments_academic_status_id_foreign" FOREIGN KEY("academic_status_id") REFERENCES "academic_statuses"("statuses_id");
