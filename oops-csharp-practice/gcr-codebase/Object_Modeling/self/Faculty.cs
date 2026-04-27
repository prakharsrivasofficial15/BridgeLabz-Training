using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Object_Modeling.self
{
    internal class Faculty
    {
        public string Name;
        public Faculty(string name) { Name = name; }
    }

    class Department
    {
        public string DeptName;
        public Department(string name) { DeptName = name; }
    }

    class University
    {
        public string Name;
        private Department[] departments;
        private Faculty[] faculties;

        public University(string name, int dSize, int fSize)
        {
            Name = name;
            departments = new Department[dSize];
            faculties = new Faculty[fSize];
        }

        public void AddDepartment(string name, int index)
        {
            departments[index] = new Department(name);
        }

        public void AddFaculty(Faculty faculty, int index)
        {
            faculties[index] = faculty;
        }
    }
}
