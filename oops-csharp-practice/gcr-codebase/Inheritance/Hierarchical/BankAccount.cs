using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Inheritance.Hierarchical
{
    internal class BankAccount
    {
        public string AccountNumber;
        public double Balance;

        public BankAccount(string accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public virtual void DisplayAccountType()
        {
            Console.WriteLine("General Bank Account");
        }
    }

    class SavingsAccount : BankAccount
    {
        public double InterestRate;

        public SavingsAccount(string accountNumber, double balance, double interestRate)
            : base(accountNumber, balance)
        {
            InterestRate = interestRate;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine("Account Type: Savings Account");
            Console.WriteLine("Interest Rate: " + InterestRate + "%");
        }
    }

    class CheckingAccount : BankAccount
    {
        public int WithdrawalLimit;

        public CheckingAccount(string accountNumber, double balance, int withdrawalLimit)
            : base(accountNumber, balance)
        {
            WithdrawalLimit = withdrawalLimit;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine("Account Type: Checking Account");
            Console.WriteLine("Withdrawal Limit: " + WithdrawalLimit);
        }
    }

    class FixedDepositAccount : BankAccount
    {
        public int Tenure; // in years

        public FixedDepositAccount(string accountNumber, double balance, int tenure)
            : base(accountNumber, balance)
        {
            Tenure = tenure;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine("Account Type: Fixed Deposit Account");
            Console.WriteLine("Tenure: " + Tenure + " years");
        }
    }

    class BankTest
    {
        static void Main()
        {
            BankAccount[] accounts = new BankAccount[3];

            accounts[0] = new SavingsAccount("SA101", 50000, 4.5);
            accounts[1] = new CheckingAccount("CA102", 30000, 5);
            accounts[2] = new FixedDepositAccount("FD103", 100000, 3);

            for (int i = 0; i < accounts.Length; i++)
            {
                Console.WriteLine("Account Number: " + accounts[i].AccountNumber);
                Console.WriteLine("Balance: " + accounts[i].Balance);
                accounts[i].DisplayAccountType();
                Console.WriteLine();
            }
        }
    }
}
