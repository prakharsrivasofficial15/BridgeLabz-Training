using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Vehicle_Rental_System
{
    public interface IInsurable
    {
        decimal CalculateInsurance();
        string GetInsuranceDetails();
    }


}
