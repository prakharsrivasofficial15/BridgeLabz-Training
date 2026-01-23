using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message) { }
    }

    class BankAccount
    {
        private double balance;

        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }

        public void Withdraw(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Invalid amount!");
            }

            if (amount > balance)
            {
                throw new InsufficientFundsException("Insufficient balance!");
            }

            balance -= amount;
            Console.WriteLine("Withdrawal successful, new balance: " + balance);
        }

        static void Main()
        {
            BankAccount account = new BankAccount(1000);

            try
            {
                Console.Write("Enter withdrawal amount: ");
                double amount = double.Parse(Console.ReadLine());

                account.Withdraw(amount);
            }
            catch (InsufficientFundsException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format!");
            }
        }
    }
}
