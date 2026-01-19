using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashDealz
{
    class ConcreteProduct : Product
    {
        public ConcreteProduct(int id, string name, int discount) : base(id, name, discount) { }
    }

}
