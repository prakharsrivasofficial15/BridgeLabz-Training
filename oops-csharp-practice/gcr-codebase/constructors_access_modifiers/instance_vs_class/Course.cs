using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.constructors_access_modifiers.instance_vs_class
{
    internal class Course
    {
        //Instance variables
        private string courseName;
        private int duration;
        private double fee;

        //Class variable
        private static string instituteName = "Golden Institute";

        // Constructor
        public Course(string courseName, int duration, double fee)
        {
            this.courseName = courseName;
            this.duration = duration;
            this.fee = fee;
        }

        //instance method
        public void DisplayCourseDetails()
        {
            Console.WriteLine("Course Name: " + courseName);
            Console.WriteLine("Duration: " + duration + " months");
            Console.WriteLine("Fee: " + fee);
            Console.WriteLine("Institute: " + instituteName);
        }

        //class method
        public static void UpdateInstituteName(string newName)
        {
            instituteName = newName;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Course c1 = new Course("C#", 3, 12000);
            Course c2 = new Course("Java", 4, 15000);

            c1.DisplayCourseDetails();
            Console.WriteLine();

            Course.UpdateInstituteName("XYZ Technologies");

            c2.DisplayCourseDetails();
        }
    }
}
