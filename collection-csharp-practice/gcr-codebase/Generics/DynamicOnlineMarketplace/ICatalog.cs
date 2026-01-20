using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.DynamicOnlineMarketplace
{
    interface ICatalog
    {
        void AddProduct(ProductBase product);
        void DisplayProducts();
    }
}

