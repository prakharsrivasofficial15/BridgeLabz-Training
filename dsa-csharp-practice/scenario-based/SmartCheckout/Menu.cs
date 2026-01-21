using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCheckout
{
    sealed class Menu
    {
        private CheckoutService service;

        public Menu(CheckoutService service)
        {
            this.service = service;
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("\nSmartCheckout Menu");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. Process Billing");
                Console.WriteLine("3. View Next Customer");
                Console.WriteLine("4. View Stock");
                Console.WriteLine("5. Exit");

                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddCustomerMenu();
                        break;

                    case 2:
                        service.ProcessBilling();
                        break;

                    case 3:
                        service.ViewNextCustomer();
                        break;

                    case 4:
                        service.ViewStock();
                        break;

                    case 5:
                        Console.WriteLine("Exiting system...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

        private void AddCustomerMenu()
        {
            Console.Write("Enter Customer ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter number of items: ");
            int count = int.Parse(Console.ReadLine());

            string[] items = new string[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter item " + (i + 1) + ": ");
                items[i] = Console.ReadLine();
            }

            // You should have a concrete customer class
            Customer customer = new RegularCustomer(id, name, items);

            service.AddCustomer(customer);
        }
    }
}
