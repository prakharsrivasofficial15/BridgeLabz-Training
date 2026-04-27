using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Online_Food_Delivery
{
    public class OrderProcessor
    {
        public static void ProcessOrder(FoodItem[] foodItems)
        {
            for (int i = 0; i < foodItems.Length; i++)
            {
                FoodItem item = foodItems[i];
                item.GetItemDetails();

                decimal totalPrice = item.CalculateTotalPrice();
                decimal discount = 0;

                if (item is IDiscountable)
                {
                    IDiscountable discountableItem = (IDiscountable)item;
                    discount = discountableItem.ApplyDiscount();
                    Console.WriteLine(discountableItem.GetDiscountDetails());
                }

                Console.WriteLine("Total Price: " + totalPrice);
                Console.WriteLine("Discount: " + discount);
                Console.WriteLine("Final Price: " + (totalPrice - discount));
            }
        }
    }

}
