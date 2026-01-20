using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AadharNumbers
{
    public class Aadhar
    {
        protected long aadharNumber;

        public Aadhar(long aadharNumber)
        {
            this.aadharNumber = aadharNumber;
        }

        public long getAadharNumber()
        {
            return aadharNumber; 
        }
    }
}
