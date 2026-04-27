using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Employee
{
    public class FullTimeEmployee : Employee
    {
        private decimal _bonus;

        public FullTimeEmployee(int employeeId, string name, decimal baseSalary, decimal bonus)
            : base(employeeId, name, baseSalary)
        {
            _bonus = bonus;
        }

        public override decimal CalculateSalary()
        {
            return BaseSalary + _bonus;
        }
    }

}
