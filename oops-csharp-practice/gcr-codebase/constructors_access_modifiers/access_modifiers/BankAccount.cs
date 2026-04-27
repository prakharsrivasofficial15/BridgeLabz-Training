using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Problem 3: Bank Account Management
Create a BankAccount class with:
accountNumber (public)
accountHolder (protected)
balance (private)
Implement methods to:
Access and modify balance using public methods.
Create a subclass SavingsAccount to demonstrate access to accountNumber and accountHolder.
 */

namespace Assignment.constructors_access_modifiers.access_modifiers
{
    internal class BankAccount
    {
        public int accountNumber;         // public
        protected string accountHolder;   // protected
        private double balance;            // private

        public BankAccount(int accNo, string holder, double balance)
        {
            accountNumber = accNo;
            accountHolder = holder;
            this.balance = balance;
        }

        // Public methods to access private member
        public double GetBalance()
        {
            return balance;
        }

        public void SetBalance(double amount)
        {
            balance = amount;
        }
    }

    class SavingsAccount : BankAccount
    {
        public SavingsAccount(int accNo, string holder, double balance)
            : base(accNo, holder, balance)
        {
        }

        public void DisplaySavingsAccount()
        {
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Account Holder: " + accountHolder);
        }
    }
}
