using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class ShoppingCart
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> cart = new Dictionary<string, double>();
            LinkedList<string> order = new LinkedList<string>();
            SortedDictionary<double, List<string>> sortedByPrice = new SortedDictionary<double, List<string>>();

            Console.Write("Enter number of items: ");
            int n = int.Parse(Console.ReadLine());

            //Take item details from user
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter item name: ");
                string name = Console.ReadLine();

                Console.Write("Enter item price: ");
                double price = double.Parse(Console.ReadLine());

                cart[name] = price;
            }

            //Add items to linked list and sorted dictionary
            foreach (var item in cart)
            {
                order.AddLast(item.Key);

                if (!sortedByPrice.ContainsKey(item.Value))
                {
                    sortedByPrice[item.Value] = new List<string>();
                }
                sortedByPrice[item.Value].Add(item.Key);
            }

            //Display sorted items
            Console.WriteLine("\nItems sorted by price:");
            foreach (var kv in sortedByPrice)
            {
                for (int i = 0; i < kv.Value.Count; i++)
                {
                    Console.WriteLine($"{kv.Value[i]} : {kv.Key}");
                }
            }

            Console.ReadLine();
        }
    }
}
