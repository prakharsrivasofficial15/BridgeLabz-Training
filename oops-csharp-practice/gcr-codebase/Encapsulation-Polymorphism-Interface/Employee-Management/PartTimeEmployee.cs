using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Employee
{
    public class PartTimeEmployee : Employee
    {
        private int _hoursWorked;
        private decimal _hourlyRate;

        public PartTimeEmployee(int employeeId, string name, int hoursWorked, decimal hourlyRate)
            : this(employeeId, name, 0, hoursWorked, hourlyRate)
        {
        }

        public PartTimeEmployee(int employeeId, string name, decimal baseSalary, int hoursWorked, decimal hourlyRate)
            : base(employeeId, name, baseSalary)
        {
            _hoursWorked = hoursWorked;
            _hourlyRate = hourlyRate;
        }

        public override decimal CalculateSalary()
        {
            return _hoursWorked * _hourlyRate;
        }
    }

}
