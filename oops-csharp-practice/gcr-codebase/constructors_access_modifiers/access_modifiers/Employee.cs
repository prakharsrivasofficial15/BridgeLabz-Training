using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Problem 4: Employee Records
Develop an Employee class with:
employeeID (public)
department (protected)
salary (private)
Implement methods to:
Modify salary using a public method.
Create a subclass Manager to access employeeID and department.
 */

namespace Assignment.constructors_access_modifiers.access_modifiers
{
    internal class Employee
    {
        public int employeeID;          // public
        protected string department;    // protected
        private double salary;           // private

        public Employee(int id, string dept, double salary)
        {
            employeeID = id;
            department = dept;
            this.salary = salary;
        }

        // Public method to modify private salary
        public void SetSalary(double salary)
        {
            this.salary = salary;
        }

        public double GetSalary()
        {
            return salary;
        }
    }

    class Manager : Employee
    {
        public Manager(int id, string dept, double salary)
            : base(id, dept, salary)
        {
        }

        public void DisplayManager()
        {
            Console.WriteLine("Employee ID: " + employeeID);
            Console.WriteLine("Department: " + department);
        }
    }
}
