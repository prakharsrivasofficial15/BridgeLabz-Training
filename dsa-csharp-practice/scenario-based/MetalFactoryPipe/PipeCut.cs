using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalFactoryPipe
{
    internal class PipeCut
    {
        public int Length { get; set; }
        public int Price { get; set; }

        public PipeCut(int length, int price)
        {
            Length = length;
            Price = price;
        }
    }
}
