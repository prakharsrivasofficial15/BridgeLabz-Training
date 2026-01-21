using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCheckout
{
    internal class Entry
    {
        static void Main(string[] args)
        {
            CustomQueue queue = new CustomQueue();
            CustomHashMap map = new CustomHashMap(10);

            map.Insert(new StoreItem("Milk", 30, 10));
            map.Insert(new StoreItem("Bread", 25, 15));
            map.Insert(new StoreItem("Eggs", 6, 50));
            map.Insert(new StoreItem("Rice", 60, 20));
            map.Insert(new StoreItem("Sugar", 45, 25));
            map.Insert(new StoreItem("Salt", 20, 40));
            map.Insert(new StoreItem("Oil", 150, 10));
            map.Insert(new StoreItem("Butter", 90, 12));
            map.Insert(new StoreItem("Cheese", 120, 8));
            map.Insert(new StoreItem("Tea", 70, 30));
            map.Insert(new StoreItem("Coffee", 180, 15));
            map.Insert(new StoreItem("Biscuit", 30, 50));

            CheckoutService service = new CheckoutService(queue, map);
            Menu menu = new Menu(service);

            menu.Start();
        }
    }
}
