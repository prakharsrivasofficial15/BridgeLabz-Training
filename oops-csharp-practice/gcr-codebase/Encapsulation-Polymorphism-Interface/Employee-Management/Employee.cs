using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Employee
{
    using System;

    public abstract class Employee : IDepartment
    {
        private int _employeeId;
        private string _name;
        private decimal _baseSalary;
        private string _department;

        public int EmployeeId
        {
            get { return _employeeId; }
            protected set
            {
                if (value <= 0)
                    throw new ArgumentException("Employee ID must be positive");
                _employeeId = value;
            }
        }

        public string Name
        {
            get { return _name; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Name cannot be empty");
                _name = value;
            }
        }

        public decimal BaseSalary
        {
            get { return _baseSalary; }
            protected set
            {
                if (value < 0)
                    throw new ArgumentException("Salary cannot be negative");
                _baseSalary = value;
            }
        }

        protected Employee(int employeeId, string name, decimal baseSalary)
        {
            EmployeeId = employeeId;
            Name = name;
            BaseSalary = baseSalary;
        }

        public abstract decimal CalculateSalary();

        public void AssignDepartment(string departmentName)
        {
            _department = departmentName;
        }

        public string GetDepartmentDetails()
        {
            return _department;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("ID: " + EmployeeId);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Department: " + _department);
            Console.WriteLine("Salary: " + CalculateSalary());
        }
    }
}
