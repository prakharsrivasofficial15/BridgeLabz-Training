using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.UniversityCourseManagement
{
    interface ICourseManager<out T> where T : CourseType
    {
        IEnumerable<T> GetCourses();
    }
}
