using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Online_Food_Delivery
{
    class Program
    {
        static void Main()
        {
            FoodItem[] orderItems = new FoodItem[2];

            orderItems[0] = new VegItem("Paneer Butter Masala", 250, 2);
            orderItems[1] = new NonVegItem("Chicken Biryani", 300, 1);

            OrderProcessor.ProcessOrder(orderItems);
        }
    }
}
