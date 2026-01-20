using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AadharNumbers
{
    internal class AadharServiceImpl : IAadharOperations
    {
        private Aadhar[] aadhars;
        private int size;

        public AadharServiceImpl(Aadhar[] aadhars, int size)
        {
            this.aadhars = aadhars;
            this.size = size;
        }

        public void SortAadharNumbers()
        {
            RadixSort.Sort(aadhars, size);
        }

        public int Search(long key)
        {
            return BinarySearch.Search(aadhars, size, key);
        }

        public void Display()
        {
            for (int i = 0; i < size; i++)
                Console.WriteLine(aadhars[i].getAadharNumber());
        }
    }
}
