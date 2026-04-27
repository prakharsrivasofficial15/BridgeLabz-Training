using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.c__Keywords
{
    internal class Product
    {
        public static double Discount = 10; // percentage

        public string ProductName;
        public double Price;
        public int Quantity;
        public readonly string ProductID;

        public Product(string productName, double price, int quantity, string productId)
        {
            this.ProductName = productName;
            this.Price = price;
            this.Quantity = quantity;
            this.ProductID = productId;
        }

        public static void UpdateDiscount(double newDiscount)
        {
            Discount = newDiscount;
        }

        public static void DisplayProductDetails(object obj)
        {
            if (obj is Product p)
            {
                Console.WriteLine($"{p.ProductName} - {p.ProductID} - {p.Price} - Qty:{p.Quantity} - Discount:{Discount}%");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("Laptop", 75000, 1, "P001");
            Product p2 = new Product("Mouse", 1200, 2, "P002");

            Product.DisplayProductDetails(p1);
            Product.DisplayProductDetails(p2);

            Product.UpdateDiscount(15);
            Console.WriteLine("Discount Updated");

            Product.DisplayProductDetails(p1);

            Console.ReadLine();
        }
    }
}

