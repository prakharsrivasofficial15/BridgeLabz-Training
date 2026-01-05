using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Scenario.Hosptital_Management
{
    public class Bill
    {
        public void PrintBill(IPayable payable)
        {
            Console.WriteLine($"Total Bill Amount: {payable.CalculateBill()}");
        }
    }

}
