using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCheckout
{
    class CheckoutService : ICheckoutOperations
    {
        private CustomQueue customerQueue;
        private CustomHashMap stockMap;

        public CheckoutService(CustomQueue queue, CustomHashMap map)
        {
            customerQueue = queue;
            stockMap = map;
        }

        // Add customer to queue
        public void AddCustomer(Customer customer)
        {
            customerQueue.Enqueue(customer);
            Console.WriteLine("Customer added to queue.");
        }

        // Remove customer from queue
        public void RemoveCustomer()
        {
            Customer removed = customerQueue.Dequeue();
            if (removed == null)
                Console.WriteLine("Queue is empty.");
            else
                Console.WriteLine("Customer removed from queue.");
        }

        // View next customer
        public void ViewNextCustomer()
        {
            Customer next = customerQueue.Peek();
            if (next == null)
                Console.WriteLine("No customers in queue.");
            else
                Console.WriteLine("Next customer: " + next.CustomerName);
        }

        // Process billing
        public void ProcessBilling()
        {
            Customer customer = customerQueue.Peek();
            if (customer == null)
            {
                Console.WriteLine("No customers to process.");
                return;
            }

            Console.WriteLine("Processing billing for: " + customer.CustomerName);
            double total = 0;

            foreach (string itemName in customer.Items)
            {
                Item item = stockMap.Search(itemName);

                if (item == null)
                {
                    Console.WriteLine(itemName + " not found.");
                    continue;
                }

                if (item.Stock > 0)
                {
                    total += item.Price;
                    item.Stock -= 1;
                    Console.WriteLine(itemName + " added to bill.");
                }
                else
                {
                    Console.WriteLine(itemName + " is out of stock.");
                }
            }

            customer.TotalBill = total;
            Console.WriteLine("Total Bill: " + total);

            customerQueue.Dequeue(); // remove after billing
        }

        // View stock
        public void ViewStock()
        {
            stockMap.Display();
        }
    }
}
