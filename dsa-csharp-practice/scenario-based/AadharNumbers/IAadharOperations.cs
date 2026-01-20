using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AadharNumbers
{
    internal interface IAadharOperations
    {
        void SortAadharNumbers();
        long Search(long key);
        void Display();
    }
}
