using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.UniversityCourseManagement
{
    abstract class CourseType
    {
        public string CourseName { get; set; }

        protected CourseType(string courseName)
        {
            CourseName = courseName;
        }

        public abstract void Evaluate();
    }
}
