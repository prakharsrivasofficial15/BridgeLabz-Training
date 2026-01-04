using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///*Sample Program 3: Employee Management System
//Design an Employee class with the following features:
//static: 
//    A static variable CompanyName shared by all employees.
//    A static method DisplayTotalEmployees() to show the total number of employees.
//this: 
//    Use this to initialize Name, Id, and Designation in the constructor.
//readonly: 
//    Use a readonly variable Id for the employee ID, which cannot be modified after assignment.
//is operator: 
//    Check if a given object is an instance of the Employee class before printing the employee details.
//*/

namespace Assignment.c__Keywords
{
    internal class EmployeeManagement
    {
        public static string CompanyName = "GoldenTime";
        private static int totalEmployees = 0;

        public string Name;
        public readonly string Id;
        public string Designation;

        public EmployeeManagement(string name, string id, string designation)
        {
            this.Name = name;
            this.Id = id;
            this.Designation = designation;
            totalEmployees++;
        }

        public static void DisplayCompanyName()
        {
            Console.WriteLine($"Company Name: {CompanyName}");
        }

        public static void DisplayTotalEmployees()
        {
            Console.WriteLine($"Total Employees: {totalEmployees}");
        }

        public static void DisplayEmployeeDetails(object obj)
        {
            if (obj is EmployeeManagement emp)
            {
                Console.WriteLine($"{emp.Name} - {emp.Id} - {emp.Designation}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Display company name
            EmployeeManagement.DisplayCompanyName();

            // Create employee objects
            EmployeeManagement emp1 = new EmployeeManagement(
                "John Doe",
                "EMP001",
                "Software Engineer"
            );

            EmployeeManagement emp2 = new EmployeeManagement(
                "Jane Smith",
                "EMP002",
                "Project Manager"
            );

            // Display employee details
            EmployeeManagement.DisplayEmployeeDetails(emp1);
            EmployeeManagement.DisplayEmployeeDetails(emp2);

            // Display total employees
            EmployeeManagement.DisplayTotalEmployees();

            // Pause console
            Console.ReadLine();
        }
    }
}
