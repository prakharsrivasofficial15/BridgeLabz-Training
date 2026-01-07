using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.E_Commerce_Platform
{
    public class Clothing : Product, ITaxable
    {
        public Clothing(int productId, string name, decimal price)
            : base(productId, name, price)
        {
        }

        public override decimal CalculateDiscount()
        {
            return Price * 0.20m;
        }

        public decimal CalculateTax()
        {
            return Price * 0.12m;
        }

        public string GetTaxDetails()
        {
            return "Clothing Tax: 12%";
        }
    }

}
