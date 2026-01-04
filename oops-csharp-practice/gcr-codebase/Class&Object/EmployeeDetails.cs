using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Class_Object
{
    internal class EmployeeDetails
    {
        private string name;
        private int id;
        private double salary;

        // Constructor
        public EmployeeDetails(string name, int id, double salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }

        // Method to display employee details
        public void DisplayDetails()
        {
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Employee ID: " + id);
            Console.WriteLine("Salary: " + salary);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            EmployeeDetails emp = new EmployeeDetails("Rahul", 101, 45000);
            emp.DisplayDetails();
        }
    }
}
