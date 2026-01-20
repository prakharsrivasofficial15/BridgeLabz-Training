using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.SmartWarehouseManagement
{
    internal class WareHouseController
    {
        Storage<Electronics> electronicsStorage = new Storage<Electronics>();
        Storage<Groceries> groceriesStorage = new Storage<Groceries>();
        Storage<Furniture> furnitureStorage = new Storage<Furniture>();

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n1. Add Electronics");
                Console.WriteLine("2. Add Groceries");
                Console.WriteLine("3. Add Furniture");
                Console.WriteLine("4. Display All Items");
                Console.WriteLine("5. Exit");

                Console.WriteLine("Enter Your Choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the electronics item Id: ");
                        int eId = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Electronics Gadget to be added: ");
                        string eItem = Console.ReadLine();

                        electronicsStorage.AddItem(new Electronics(eId, eItem));
                        break;

                    case 2:
                        Console.WriteLine("Enter the groceries item Id: ");
                        int gId = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter groceries to be added: ");
                        string gItem = Console.ReadLine();

                        electronicsStorage.AddItem(new Electronics(gId, gItem));
                        break;

                    case 3:
                        Console.WriteLine("Enter the furniture item Id: ");
                        int fId = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter furniture to be added: ");
                        string fItem = Console.ReadLine();

                        electronicsStorage.AddItem(new Electronics(fId, fItem));
                        break;

                    case 4:
                        electronicsStorage.DisplayItem();
                        groceriesStorage.DisplayItem();
                        furnitureStorage.DisplayItem();
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }
    }
}
