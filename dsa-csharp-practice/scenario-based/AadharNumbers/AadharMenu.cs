using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AadharNumbers
{
    internal class AadharMenu
    {
        private AadharServiceImpl service;

        public AadharMenu(AadharServiceImpl service)
        {
            this.service = service;
        }

        public void Start()
        {
            while (true) 
            {
                Console.WriteLine("\n1. Sort Aadhar Numbers");
                Console.WriteLine("2. Search Aadhar Number");
                Console.WriteLine("3. Display Aadhar Numbers");
                Console.WriteLine("4. Exit");

                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        service.SortAadharNumbers();
                        Console.WriteLine("Sorted successfully");
                        break;

                    case 2:
                        Console.Write("Enter Aadhar to search: ");
                        long key = long.Parse(Console.ReadLine());
                        int pos = service.Search(key);
                        Console.WriteLine(pos == -1 ? "Not Found" : "Found at index " + pos);
                        break;

                    case 3:
                        service.Display();
                        break;
                }

            }
        }
    }
}
