using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Object_Modeling.self
{
    internal class Product
    {
        public string ProductName;
        public Product(string name) { ProductName = name; }
    }

    class Order
    {
        public string OrderId;
        private Product[] products;
        private int count;

        public Order(string id, int size)
        {
            OrderId = id;
            products = new Product[size];
            count = 0;
        }

        public void AddProduct(Product product)
        {
            products[count++] = product;
        }

        public void ShowOrder()
        {
            Console.WriteLine("Order: " + OrderId);
            for (int i = 0; i < count; i++)
                Console.WriteLine("- " + products[i].ProductName);
        }
    }

    class Customer
    {
        public string Name;
        public Customer(string name) { Name = name; }

        public void PlaceOrder(Order order)
        {
            Console.WriteLine(Name + " placed order " + order.OrderId);
        }
    }
}
