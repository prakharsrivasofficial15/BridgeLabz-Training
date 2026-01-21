using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCheckout
{
    class RegularCustomer : Customer
    {
        public RegularCustomer(int id, string name, string[] items)
            : base(id, name, items)
        {
        }
    }
}
