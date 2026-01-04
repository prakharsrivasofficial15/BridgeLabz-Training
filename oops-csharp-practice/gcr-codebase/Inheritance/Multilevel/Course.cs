using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Inheritance.Multilevel
{
    internal class Course
    {
        public string CourseName;
        public int Duration; // in hours

        public Course(string courseName, int duration)
        {
            CourseName = courseName;
            Duration = duration;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine("Course Name: " + CourseName);
            Console.WriteLine("Duration: " + Duration + " hours");
        }
    }

    class OnlineCourse : Course
    {
        public string Platform;
        public bool IsRecorded;

        public OnlineCourse(string courseName, int duration, string platform, bool isRecorded)
            : base(courseName, duration)
        {
            Platform = platform;
            IsRecorded = isRecorded;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Platform: " + Platform);
            Console.WriteLine("Recorded: " + IsRecorded);
        }
    }

    class PaidOnlineCourse : OnlineCourse
    {
        public double Fee;
        public double Discount;

        public PaidOnlineCourse(
            string courseName,
            int duration,
            string platform,
            bool isRecorded,
            double fee,
            double discount)
            : base(courseName, duration, platform, isRecorded)
        {
            Fee = fee;
            Discount = discount;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Course Fee: " + Fee);
            Console.WriteLine("Discount: " + Discount + "%");
            Console.WriteLine("Final Fee: " + (Fee - (Fee * Discount / 100)));
        }
    }

    class CourseTest
    {
        static void Main()
        {
            PaidOnlineCourse course = new PaidOnlineCourse(
                "C# Advanced",
                40,
                "Udemy",
                true,
                5000,
                20
            );

            course.DisplayDetails();
        }
    }
}
