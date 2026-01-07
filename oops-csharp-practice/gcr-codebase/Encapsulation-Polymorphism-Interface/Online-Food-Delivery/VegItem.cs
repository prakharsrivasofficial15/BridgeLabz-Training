using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Online_Food_Delivery
{
    public class VegItem : FoodItem, IDiscountable
    {
        public VegItem(string itemName, decimal price, int quantity)
            : base(itemName, price, quantity)
        {
        }

        public override decimal CalculateTotalPrice()
        {
            return Price * Quantity;
        }

        public decimal ApplyDiscount()
        {
            return CalculateTotalPrice() * 0.10m;
        }

        public string GetDiscountDetails()
        {
            return "Veg Item Discount: 10%";
        }
    }

}
