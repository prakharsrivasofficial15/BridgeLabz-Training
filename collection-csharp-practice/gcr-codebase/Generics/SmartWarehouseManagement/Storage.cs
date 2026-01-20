using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.SmartWarehouseManagement
{
    internal class Storage<T> : IStorage<T> where T: WarehouseItem
    {
        private List<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item);
            Console.WriteLine($"{item.Name} added successfully");
        }

        public void DisplayItem()
        {
            Console.WriteLine("Items List: ");
            foreach(T item in items)
            {
                Console.WriteLine(item); 
            }
        }
    }
}
