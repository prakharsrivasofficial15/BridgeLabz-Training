using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.E_Commerce_Platform
{
    class Program
    {
        static void Main()
        {
            Product[] products = new Product[3];

            products[0] = new Electronics(1, "Laptop", 60000);
            products[1] = new Clothing(2, "Jacket", 3000);
            products[2] = new Groceries(3, "Rice Bag", 1200);

            PriceCalculator.PrintFinalPrices(products);
        }
    }
}
