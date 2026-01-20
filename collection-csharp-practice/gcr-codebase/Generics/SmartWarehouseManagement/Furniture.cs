using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.SmartWarehouseManagement
{
    internal class Furniture : WarehouseItem
    {
        public Furniture(int  id,  string name) : base(id, name) { }

        public override void display()
        {
            Console.WriteLine($"Furniture: Id: {Id} Name: {Name}");
        }
    }
}
