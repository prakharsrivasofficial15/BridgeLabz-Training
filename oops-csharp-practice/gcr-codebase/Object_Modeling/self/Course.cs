using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Object_Modeling.self
{
    internal class Course
    {
        public string CourseName;
        private Student[] students;
        private int count;

        public Course(string name, int size)
        {
            CourseName = name;
            students = new Student[size];
            count = 0;
        }

        public void AddStudent(Student student)
        {
            students[count++] = student;
        }

        public void ShowStudents()
        {
            Console.WriteLine("Course: " + CourseName);
            for (int i = 0; i < count; i++)
                Console.WriteLine("- " + students[i].Name);
        }
    }

    class Student
    {
        public string Name;
        private Course[] courses;
        private int count;

        public Student(string name, int size)
        {
            Name = name;
            courses = new Course[size];
            count = 0;
        }

        public void EnrollCourse(Course course)
        {
            courses[count++] = course;
            course.AddStudent(this);
        }

        public void ViewCourses()
        {
            Console.WriteLine("Student: " + Name);
            for (int i = 0; i < count; i++)
                Console.WriteLine("- " + courses[i].CourseName);
        }
    }

    class School
    {
        public string SchoolName;
        public Student[] students;

        public School(string name, int size)
        {
            SchoolName = name;
            students = new Student[size];
        }
    }
}
