using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.E_Commerce_Platform
{
    public class Electronics : Product, ITaxable
    {
        public Electronics(int productId, string name, decimal price)
            : base(productId, name, price)
        {
        }

        public override decimal CalculateDiscount()
        {
            return Price * 0.10m;
        }

        public decimal CalculateTax()
        {
            return Price * 0.18m;
        }

        public string GetTaxDetails()
        {
            return "Electronics Tax: 18%";
        }
    }

}
