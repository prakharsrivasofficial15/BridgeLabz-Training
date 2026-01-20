using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.UniversityCourseManagement
{
    class CourseController
    {
        Course<ExamCourse> examCourses = new Course<ExamCourse>();
        Course<AssignmentCourse> assignmentCourses = new Course<AssignmentCourse>();

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\nUniversity Course Management System");
                Console.WriteLine("1. Add Exam Course");
                Console.WriteLine("2. Add Assignment Course");
                Console.WriteLine("3. Display All Courses");
                Console.WriteLine("4. Exit");

                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Course name: ");
                        string examName = Console.ReadLine();

                        Console.Write("Marks: ");
                        double marks = double.Parse(Console.ReadLine());

                        examCourses.AddCourse(new ExamCourse(examName, marks));
                        Console.WriteLine("Exam course added!");
                        break;

                    case 2:
                        Console.Write("Course name: ");
                        string assignName = Console.ReadLine();

                        Console.Write("Score: ");
                        double score = double.Parse(Console.ReadLine());

                        assignmentCourses.AddCourse(new AssignmentCourse(assignName, score));
                        Console.WriteLine("Assignment course added!");
                        break;

                    case 3:
                        Console.WriteLine("\nExam Courses");
                        examCourses.DisplayCourses();

                        Console.WriteLine("\nAssignment Courses");
                        assignmentCourses.DisplayCourses();
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
    }
}
