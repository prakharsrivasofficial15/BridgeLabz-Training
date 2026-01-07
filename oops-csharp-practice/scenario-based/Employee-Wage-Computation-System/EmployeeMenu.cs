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
                Console.WriteLine("\nWelcome to the Employee Wage Computation System");
                Console.WriteLine("1. Full Time Employee");
                Console.WriteLine("2. Part Time Employee");
                Console.WriteLine("3. Exit");

                int mainChoice = Convert.ToInt32(Console.ReadLine());

                //Full Time Employee Menu
                if (mainChoice == 1)
                {
                    bool fullTimeFlag = true;

                    while (fullTimeFlag)
                    {
                        Console.WriteLine("\nFull Time Employee Menu");
                        Console.WriteLine("1. Add Employee");
                        Console.WriteLine("2. Check Employee Attendance");
                        Console.WriteLine("3. Calculate Daily Wage");
                        Console.WriteLine("4. Back");

                        int ftChoice = Convert.ToInt32(Console.ReadLine());

                        if (ftChoice == 1)
                        {
                            e1 = employee.addEmployee();
                        }
                        else if (ftChoice == 2)
                        {
                            employee.CheckAttendance(e1.GetId());
                        }
                        else if (ftChoice == 3)
                        {
                            employee.CalculateDailyWage(e1.GetId());
                        }
                        else if (ftChoice == 4)
                        {
                            fullTimeFlag = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Choice");
                        }
                    }
                }

                //Full Time Employee Menu
                else if (mainChoice == 2)
                {
                    bool partTimeFlag = true;

                    while (partTimeFlag)
                    {
                        Console.WriteLine("\nPart Time Employee Menu");
                        Console.WriteLine("1. Add Employee");
                        Console.WriteLine("2. Calculate Part Time Wage");
                        Console.WriteLine("3. Back");

                        int ptChoice = Convert.ToInt32(Console.ReadLine());

                        if (ptChoice == 1)
                        {
                            e1 = employee.addEmployee();
                        }
                        else if (ptChoice == 2)
                        {
                            employee.CalculatePartTimeWage();
                        }
                        else if (ptChoice == 3)
                        {
                            partTimeFlag = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Choice");
                        }
                    }
                }

                //exit
                else if (mainChoice == 3)
                {
                    Console.WriteLine("Exiting the System");
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }
        }
    }
}
