using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.UniversityCourseManagement
{
    class Course<T> : ICourseManager<T> where T : CourseType
    {
        private List<T> courses = new List<T>();

        public void AddCourse(T course)
        {
            courses.Add(course);
        }

        public IEnumerable<T> GetCourses()
        {
            return courses;
        }

        public void DisplayCourses()
        {
            foreach (var c in courses)
            {
                c.Evaluate();
            }
        }
    }
}
