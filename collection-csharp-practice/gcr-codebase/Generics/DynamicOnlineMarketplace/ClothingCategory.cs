using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.DynamicOnlineMarketplace
{
    class ClothingCategory
    {
        public int Size { get; set; }

        public ClothingCategory(int size)
        {
            Size = size;
        }
        public override string ToString()
        {
            return $"Size {Size}";
        }
    }
}
