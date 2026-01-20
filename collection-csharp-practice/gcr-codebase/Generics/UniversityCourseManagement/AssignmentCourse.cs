using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.UniversityCourseManagement
{
    class AssignmentCourse : CourseType
    {
        public double AssignmentScore { get; set; }

        public AssignmentCourse(string name, double score) : base(name)
        {
            AssignmentScore = score;
        }

        public override void Evaluate()
        {
            Console.WriteLine($"[Assignment] {CourseName} - Score: {AssignmentScore}");
        }
    }
}
