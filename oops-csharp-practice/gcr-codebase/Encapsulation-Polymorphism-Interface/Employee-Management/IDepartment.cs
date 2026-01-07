using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Employee
{
    public interface IDepartment
    {
        void AssignDepartment(string departmentName);
        string GetDepartmentDetails();
    }
}
