using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Employee
{
    class Program
    {
        static void Main()
        {
            Employee[] employees = new Employee[2];

            employees[0] = new FullTimeEmployee(1, "Alice", 50000, 10000);
            employees[1] = new PartTimeEmployee(2, "Bob", 120, 50);

            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].AssignDepartment("IT Department");

                if (employees[i] is FullTimeEmployee)
                {
                    Console.WriteLine("Full-Time Employee detected");
                }
                else if (employees[i] is PartTimeEmployee)
                {
                    Console.WriteLine("Part-Time Employee detected");
                }

                employees[i].DisplayDetails();
            }
        }
    }

}
