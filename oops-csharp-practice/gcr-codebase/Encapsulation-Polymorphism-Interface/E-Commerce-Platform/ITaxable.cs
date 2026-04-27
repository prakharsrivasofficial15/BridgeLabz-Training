using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.E_Commerce_Platform
{
    public interface ITaxable
    {
        decimal CalculateTax();
        string GetTaxDetails();
    }


}
