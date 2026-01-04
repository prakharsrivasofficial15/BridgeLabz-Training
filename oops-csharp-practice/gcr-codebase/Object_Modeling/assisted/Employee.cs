using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Problem 3: Company and Departments (Composition) 
Description: A Company has several Department objects, and each department contains Employee objects. Model this using composition, where deleting a Company should also delete all departments and employees. 
Tasks: Define a Company class that contains multiple Department objects. 
Define an Employee class within each Department. Show the composition relationship by ensuring that when a Company object is deleted, all associated Department and Employee objects are also removed. 
Goal: 
Understand composition by implementing a relationship where Department and Employee objects cannot exist without a Company.
 */

namespace Assignment.Object_Modeling.assisted
{
    internal
class Employee
    {
        public string Name;

        public Employee(string name)
        {
            Name = name;
        }
    }

    class Department
    {
        public string DepartmentName;
        private Employee[] employees;
        private int count;

        public Department(string name, int size)
        {
            DepartmentName = name;
            employees = new Employee[size];
            count = 0;
        }

        public void AddEmployee(string name)
        {
            if (count < employees.Length)
            {
                employees[count] = new Employee(name);
                count++;
            }
        }

        public void DisplayEmployees()
        {
            Console.WriteLine("Department: " + DepartmentName);
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("- " + employees[i].Name);
            }
        }
    }

    class Company
    {
        public string CompanyName;
        private Department[] departments;
        private int count;

        public Company(string name, int size)
        {
            CompanyName = name;
            departments = new Department[size];
            count = 0;
        }

        public void AddDepartment(string name, int empSize)
        {
            if (count < departments.Length)
            {
                departments[count] = new Department(name, empSize);
                count++;
            }
        }

        public Department GetDepartment(int index)
        {
            return departments[index];
        }

        public void DisplayCompany()
        {
            Console.WriteLine("Company: " + CompanyName);
            for (int i = 0; i < count; i++)
            {
                departments[i].DisplayEmployees();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Company company = new Company("TechCorp", 2);

            company.AddDepartment("IT", 3);
            company.AddDepartment("HR", 2);

            company.GetDepartment(0).AddEmployee("Alice");
            company.GetDepartment(0).AddEmployee("Bob");

            company.GetDepartment(1).AddEmployee("Charlie");

            company.DisplayCompany();

            // When company object is destroyed, departments and employees are destroyed
            company = null;
        }
    }
}
