using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Banking_System
{
    public abstract class BankAccount
    {
        private string _accountNumber;
        private string _holderName;
        private decimal _balance;

        public string AccountNumber
        {
            get { return _accountNumber; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Account number cannot be empty.");
                _accountNumber = value;
            }
        }

        public string HolderName
        {
            get { return _holderName; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Holder name cannot be empty.");
                _holderName = value;
            }
        }

        public decimal Balance
        {
            get { return _balance; }
            protected set
            {
                if (value < 0)
                    throw new InvalidOperationException("Balance cannot be negative.");
                _balance = value;
            }
        }

        protected BankAccount(string accountNumber, string holderName, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be positive.");

            Balance += amount;
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdraw amount must be positive.");

            if (amount > Balance)
                throw new InvalidOperationException("Insufficient balance.");

            Balance -= amount;
        }

        public abstract decimal CalculateInterest();

        public void DisplayAccountDetails()
        {
            Console.WriteLine("Account: " + AccountNumber);
            Console.WriteLine("Holder: " + HolderName);
            Console.WriteLine("Balance: " + Balance);
        }
    }
}
