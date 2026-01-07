using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Banking_System
{
    class Program
    {
        static void Main()
        {
            BankAccount[] accounts = new BankAccount[2];

            accounts[0] = new SavingsAccount("SA-101", "Alice", 80000);
            accounts[1] = new CurrentAccount("CA-202", "Bob", 30000);

            BankProcessor.ProcessAccounts(accounts);
        }
    }

}
