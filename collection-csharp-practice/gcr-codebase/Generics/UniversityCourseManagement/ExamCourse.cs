using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.UniversityCourseManagement
{
    class ExamCourse : CourseType
    {
        public double Marks { get; set; }

        public ExamCourse(string name, double marks) : base(name)
        {
            Marks = marks;
        }

        public override void Evaluate()
        {
            Console.WriteLine($"[Exam] {CourseName} - Marks: {Marks}");
        }
    }
}
