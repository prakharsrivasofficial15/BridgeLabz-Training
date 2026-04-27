using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Problem 1: University Management System
Create a Student class with:
rollNumber (public)
name (protected)
CGPA (private)
Implement methods to:
Access and modify CGPA using public methods.
Create a subclass PostgraduateStudent to demonstrate the use of protected members.
 */

namespace Assignment.constructors_access_modifiers.access_modifiers
{
    internal class Student
    {
        public int rollNumber;          // public
        protected string name;          // protected
        private double cgpa;            // private

        public Student(int rollNumber, string name, double cgpa)
        {
            this.rollNumber = rollNumber;
            this.name = name;
            this.cgpa = cgpa;
        }

        // Public methods to access private member
        public double GetCGPA()
        {
            return cgpa;
        }

        public void SetCGPA(double cgpa)
        {
            this.cgpa = cgpa;
        }
    }

    class PostgraduateStudent : Student
    {
        public PostgraduateStudent(int rollNumber, string name, double cgpa)
            : base(rollNumber, name, cgpa)
        {
        }

        public void DisplayPGStudent()
        {
            Console.WriteLine("Roll Number: " + rollNumber);
            Console.WriteLine("Name: " + name); // protected access
        }
    }
}
