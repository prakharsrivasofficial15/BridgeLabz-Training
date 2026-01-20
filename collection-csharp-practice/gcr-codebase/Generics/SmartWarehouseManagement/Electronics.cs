using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.SmartWarehouseManagement
{
    internal class Electronics : WarehouseItem
    {
        public Electronics(int id , string name) : base(id, name) { }

        public override void display()
        {

            Console.WriteLine($"Electronics -> Id: {Id} Name: {Name}");
        }
    }
}
