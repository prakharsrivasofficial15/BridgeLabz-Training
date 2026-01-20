using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.DynamicOnlineMarketplace
{
    internal class Product<TCategory> : ProductBase
    {
        public TCategory Category { get; set; }

        public Product(string name, double price, TCategory category) : base(name, price)
        {
            Category = category;
        }

        public override void Display()
        {
            Console.WriteLine($"Product: {Name}, Price: {Price:C}, Category: {Category}");
        }
    }
}
