using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCheckout
{
    abstract class Item
    {
        protected string itemName;
        protected double price;
        protected int stock;

        public Item(string itemName, double price, int stock)
        {
            this.itemName = itemName;
            this.price = price;
            this.stock = stock;
        }

        public string ItemName => itemName;
        public double Price => price;
        public int Stock { get => stock; set => stock = value; }
    }
}
