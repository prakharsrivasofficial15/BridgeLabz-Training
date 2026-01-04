using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.c__Keywords
{
    internal class Student
    {
        public static string UniversityName = "Global University";
        private static int totalStudents = 0;

        public string Name;
        public readonly string RollNumber;
        public string Grade;

        public Student(string name, string rollNumber, string grade)
        {
            this.Name = name;
            this.RollNumber = rollNumber;
            this.Grade = grade;
            totalStudents++;
        }

        public static void DisplayTotalStudents()
        {
            Console.WriteLine($"Total Students: {totalStudents}");
        }

        public static void DisplayStudentDetails(object obj)
        {
            if (obj is Student s)
            {
                Console.WriteLine($"{s.Name} - {s.RollNumber} - {s.Grade}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Amit", "R001", "A");
            Student s2 = new Student("Neha", "R002", "B");

            Console.WriteLine(Student.UniversityName);
            Student.DisplayStudentDetails(s1);
            Student.DisplayStudentDetails(s2);
            Student.DisplayTotalStudents();

            Console.ReadLine();
        }
    }
}
