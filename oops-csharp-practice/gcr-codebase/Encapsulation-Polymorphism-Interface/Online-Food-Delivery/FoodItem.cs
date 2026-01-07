using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Online_Food_Delivery
{
    public abstract class FoodItem
    {
        private string _itemName;
        private decimal _price;
        private int _quantity;

        public string ItemName
        {
            get { return _itemName; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Item name cannot be empty");
                _itemName = value;
            }
        }

        public decimal Price
        {
            get { return _price; }
            protected set
            {
                if (value < 0)
                    throw new ArgumentException("Price cannot be negative");
                _price = value;
            }
        }

        public int Quantity
        {
            get { return _quantity; }
            protected set
            {
                if (value <= 0)
                    throw new ArgumentException("Quantity must be greater than zero");
                _quantity = value;
            }
        }

        protected FoodItem(string itemName, decimal price, int quantity)
        {
            ItemName = itemName;
            Price = price;
            Quantity = quantity;
        }

        public abstract decimal CalculateTotalPrice();

        public void GetItemDetails()
        {
            Console.WriteLine("Item: " + ItemName);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Quantity: " + Quantity);
        }
    }
}
