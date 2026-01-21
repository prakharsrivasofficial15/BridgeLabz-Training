using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCheckout
{
    class StoreItem : Item
    {
        public StoreItem(string name, double price, int stock) : base(name, price, stock)
        {
        }
    }
}
