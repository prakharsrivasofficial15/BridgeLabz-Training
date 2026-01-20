using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.SmartWarehouseManagement
{
    internal interface IStorage<T> where T: WarehouseItem
    {
        void AddItem(T item);
        void DisplayItem();
    }
}
