using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Scenario.Bank_Account
{
    internal class Bank
    {
        private static double minimumBalance = 2000.00;
        private static double maxTransactionLimit = 400000.00;
        private static double dailyTransactionLimit = 100000.00;

        public bool IsDepositValid(double amount)
        {
            return amount > 0 && amount <= maxTransactionLimit;
        }

        public bool CanWithdraw(double amount, double balance)
        {
            if (amount <= 0)
                return false;

            if (amount > dailyTransactionLimit)
                return false;

            if (balance - amount < minimumBalance)
                return false;

            return true;
        }
    }
}
