using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Problem 1: Product Inventory
Create a Product class with:
    Instance Variables: productName, price.
    Class Variable: totalProducts (shared among all products).
Implement the following methods:
    An instance method DisplayProductDetails() to display the details of a product.
    A class method DisplayTotalProducts() to show the total number of products created.
 */

namespace Assignment.constructors_access_modifiers.instance_vs_class
{
    internal class Product
    {
        //instance variables
        private string productName;
        private double price;

        //class variable
        private static int totalProducts = 0;

        //constructor
        public Product(string productName, double price)
        {
            this.productName = productName;
            this.price = price;
            totalProducts++;
        }

        //instance method
        public void DisplayProductDetails()
        {
            Console.WriteLine("Product Name: " + productName);
            Console.WriteLine("Price: " + price);
        }

        //class method
        public static void DisplayTotalProducts()
        {
            Console.WriteLine("Total Products Created: " + totalProducts);
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Product p1 = new Product("Laptop", 55000);
            Product p2 = new Product("Mobile", 25000);

            p1.DisplayProductDetails();
            Console.WriteLine();
            p2.DisplayProductDetails();

            Console.WriteLine();
            Product.DisplayTotalProducts();
        }
    }
}