using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.SmartWarehouseManagement
{
    internal class Groceries : WarehouseItem
    {
        public Groceries(int  id,  string name) : base(id, name) { }

        public override void display()
        {
            Console.WriteLine($"Groceries -> Id: {Id} Name: {Name}");
        }
    }
}
