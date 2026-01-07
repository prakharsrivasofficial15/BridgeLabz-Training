using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.E_Commerce_Platform
{
    public class PriceCalculator
    {
        public static void PrintFinalPrices(Product[] products)
        {
            for (int i = 0; i < products.Length; i++)
            {
                Product product = products[i];
                decimal tax = 0;

                if (product is ITaxable)
                {
                    ITaxable taxableProduct = (ITaxable)product;
                    tax = taxableProduct.CalculateTax();
                    Console.WriteLine(taxableProduct.GetTaxDetails());
                }

                decimal discount = product.CalculateDiscount();
                decimal finalPrice = product.Price + tax - discount;

                product.DisplayBasicInfo();
                Console.WriteLine("Discount: " + discount);
                Console.WriteLine("Tax: " + tax);
                Console.WriteLine("Final Price: " + finalPrice);
            }
        }
    }
}
