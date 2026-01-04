using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Problem 2: Bank and Account Holders (Association) 
Description: Model a relationship where a Bank has Customer objects associated with it. A Customer can have multiple bank accounts, and each account is linked to a Bank. 
Tasks: Define a Bank class and a Customer class. 
Use an association relationship to show that each Customer has an account in a Bank. Implement methods that enable communication, such as OpenAccount() in the Bank class and ViewBalance() in the Customer class. 
Goal:
Illustrate association by setting up a relationship between customers and the bank.
*/

namespace Assignment.Object_Modeling.assisted
{
    internal class Account
    {
        public string AccountNumber;
        public int Balance;

        public Account(string accNo, int balance)
        {
            AccountNumber = accNo;
            Balance = balance;
        }
    }

    class Customer
    {
        public string Name;
        private Account[] accounts;
        private int count;

        public Customer(string name, int size)
        {
            Name = name;
            accounts = new Account[size];
            count = 0;
        }

        public void AddAccount(Account account)
        {
            if (count < accounts.Length)
            {
                accounts[count] = account;
                count++;
            }
        }

        public void ViewBalance()
        {
            Console.WriteLine("Customer: " + Name);
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Account " + accounts[i].AccountNumber +
                                  " Balance: " + accounts[i].Balance);
            }
        }
    }

    class Bank
    {
        public string BankName;

        public Bank(string name)
        {
            BankName = name;
        }

        public Account OpenAccount(string accNo, int balance)
        {
            return new Account(accNo, balance);
        }
    }

    class Program
    {
        static void Main()
        {
            Bank bank = new Bank("ABC Bank");
            Customer customer = new Customer("John", 3);

            Account acc1 = bank.OpenAccount("A101", 5000);
            Account acc2 = bank.OpenAccount("A102", 3000);

            customer.AddAccount(acc1);
            customer.AddAccount(acc2);

            customer.ViewBalance();
        }
    }
}
