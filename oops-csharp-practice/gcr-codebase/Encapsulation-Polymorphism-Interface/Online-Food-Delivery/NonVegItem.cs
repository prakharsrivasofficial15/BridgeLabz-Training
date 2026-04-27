using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Online_Food_Delivery
{
    public class NonVegItem : FoodItem
    {
        private const decimal NonVegCharge = 50m;

        public NonVegItem(string itemName, decimal price, int quantity)
            : base(itemName, price, quantity)
        {
        }

        public override decimal CalculateTotalPrice()
        {
            return (Price * Quantity) + NonVegCharge;
        }
    }

}
