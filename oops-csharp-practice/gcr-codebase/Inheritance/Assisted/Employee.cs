using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Inheritance.Assisted
{
    internal class Employee
    {
        public string Name;
        public int Id;
        public double Salary;

        public Employee(string name, int id, double salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Salary: " + Salary);
        }
    }

    class Manager : Employee
    {
        public int TeamSize;

        public Manager(string name, int id, double salary, int teamSize)
            : base(name, id, salary)
        {
            TeamSize = teamSize;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Team Size: " + TeamSize);
        }
    }

    class Developer : Employee
    {
        public string ProgrammingLanguage;

        public Developer(string name, int id, double salary, string language)
            : base(name, id, salary)
        {
            ProgrammingLanguage = language;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Programming Language: " + ProgrammingLanguage);
        }
    }

    class Intern : Employee
    {
        public string InternshipDuration;

        public Intern(string name, int id, double salary, string duration)
            : base(name, id, salary)
        {
            InternshipDuration = duration;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Internship Duration: " + InternshipDuration);
        }
    }

    class EmployeeTest
    {
        static void Main()
        {
            Employee[] employees = new Employee[3];

            employees[0] = new Manager("Alice", 101, 80000, 10);
            employees[1] = new Developer("Bob", 102, 60000, "C#");
            employees[2] = new Intern("Charlie", 103, 20000, "6 Months");

            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].DisplayDetails();
                Console.WriteLine();
            }
        }
    }
}
