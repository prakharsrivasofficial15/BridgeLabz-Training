CREATE DATABASE College;
GO

USE College;
GO

/*
CREATE TABLE table_name (
    column_name data_type [NOT NULL | NULL],
    column_name data_type,
    ...

    CONSTRAINT constraint_name PRIMARY KEY (column_name [, column_name]),

    CONSTRAINT constraint_name UNIQUE (column_name [, column_name]),

    CONSTRAINT constraint_name
        FOREIGN KEY (column_name)
        REFERENCES referenced_table (referenced_column)
        [ON DELETE { CASCADE | NO ACTION | SET NULL }]
        [ON UPDATE { CASCADE | NO ACTION }]
);
*/

--Students table
CREATE TABLE Students(
	student_id INT PRIMARY KEY,
	name VARCHAR(200) NOT NULL,
	age INT
);

--Courses table
CREATE TABLE Courses(
    course_id INT PRIMARY KEY,
    course_name VARCHAR(100) NOT NULL,
    department VARCHAR(100)
);

--Enrollments table
CREATE TABLE Enrollments(
    student_id INT,
    course_id INT,
    enrolled_date DATE,
    PRIMARY KEY (student_id, course_id),
    FOREIGN KEY (student_id) REFERENCES Students(student_id),
    FOREIGN KEY (course_id) REFERENCES Courses(course_id)
);

-- Grades table
CREATE TABLE Grades (
    student_id INT,
    course_id INT,
    marks INT,
    PRIMARY KEY (student_id, course_id),
    FOREIGN KEY (student_id) REFERENCES Students(student_id),
    FOREIGN KEY (course_id) REFERENCES Courses(course_id)
);

--JOINS

/*
SELECT t1.column_name, t3.column_name
FROM table1 t1
JOIN table2 t2
    ON t1.common_key = t2.common_key
JOIN table3 t3
    ON t2.common_key = t3.common_key;
*/

--INNER JOIN
SELECT s.name, c.course_name, c.department
FROM Students s
INNER JOIN Enrollments e ON s.student_id = e.student_id
INNER JOIN Courses c ON e.course_id = c.course_id;

SELECT DISTINCT s.name
FROM Students s
INNER JOIN Grades g ON s.student_id = g.student_id;

--LEFT JOIN
SELECT s.name, e.course_id
FROM Students s
LEFT JOIN Enrollments e ON s.student_id = e.student_id;

SELECT c.course_name, e.student_id
FROM Courses c
LEFT JOIN Enrollments e ON c.course_id = e.course_id;

SELECT DISTINCT s.name
FROM Students s
LEFT JOIN Grades g ON s.student_id = g.student_id
INNER JOIN Enrollments e ON s.student_id = e.student_id
WHERE g.student_id IS NULL;


--RIGHT JOIN
SELECT c.course_name, s.name
FROM Students s
RIGHT JOIN Enrollments e ON s.student_id = e.student_id
RIGHT JOIN Courses c ON e.course_id = c.course_id;

SELECT c.course_name
FROM Enrollments e
RIGHT JOIN Courses c ON e.course_id = c.course_id
WHERE e.course_id IS NULL;


--FULL JOIN

SELECT s.name, c.course_name
FROM Students s
FULL JOIN Enrollments e ON s.student_id = e.student_id
FULL JOIN Courses c ON e.course_id = c.course_id;

SELECT s.name AS student, c.course_name AS course
FROM Students s
FULL JOIN Enrollments e ON s.student_id = e.student_id
FULL JOIN Courses c ON e.course_id = c.course_id
WHERE e.student_id IS NULL OR e.course_id IS NULL;


--SELF JOIN

SELECT s1.name, s2.name
FROM Students s1
JOIN Students s2
  ON s1.age = s2.age
 AND s1.student_id < s2.student_id;


--CROSS JOIN

SELECT s.name, c.course_name
FROM Students s
CROSS JOIN Courses c;


SELECT COUNT(*) AS total_rows
FROM Students
CROSS JOIN Courses;
