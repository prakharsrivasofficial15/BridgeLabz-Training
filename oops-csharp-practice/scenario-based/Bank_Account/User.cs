using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BridgeLabz_Scenario.Bank_Account
{
    internal class User
    {
        public int AccountNumber;
        public int Pin;
        public double Balance;

        public bool ValidatePin(int inputPin)
        {
            return Pin == inputPin;
        }

        public void Deposit(double amount, Bank bank)
        {
            if (!bank.IsDepositValid(amount))
            {
                Console.WriteLine("Deposit amount is invalid.");
                return;
            }

            Balance += amount;
            Console.WriteLine("Deposit successful.");
        }

        public void Withdraw(double amount, Bank bank)
        {
            if (!bank.CanWithdraw(amount, Balance))
            {
                Console.WriteLine("Withdrawal failed due to bank rules.");
                return;
            }

            Balance -= amount;
            Console.WriteLine("Withdrawal successful.");
        }

        public void CheckBalance()
        {
            Console.WriteLine("Current Balance: " + Balance);
        }
    }
}
