using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.SmartWarehouseManagement
{
    abstract class WarehouseItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public WarehouseItem(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract void display();
    }
}
