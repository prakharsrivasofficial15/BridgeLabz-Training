using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation
{
    sealed class EmployeeMenu
    {
        private IEmployee employee;
        public void employeeMenu()
        {
            employee = new EmployeeUtilityImpl();

            Employee e1 = null;
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("Welcome to the Employee Wage Computation System");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Check Employee Attendance");
                Console.WriteLine("3. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());
                if(choice == 1)
                {
                    e1 = employee.addEmployee();
                    Console.WriteLine("Employee Added Successfully");
                }
                else if(choice == 2)
                {
                    employee.CheckAttendance(e1.GetId());
                }
                else if(choice == 3)
                {
                    Console.WriteLine("Exiting the System");
                    flag = false;
                    break;
                }
            }
        }
    }
}
