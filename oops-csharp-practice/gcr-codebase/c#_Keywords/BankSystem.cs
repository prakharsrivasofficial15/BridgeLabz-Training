using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///*Sample Program 1: Bank Account System
//Create a BankAccount class with the following features:
//static: 
//    A static variable bankName shared across all accounts.
//    A static method GetTotalAccounts() to display the total number of accounts.
//this: 
//    Use this to resolve ambiguity in the constructor when initializing AccountHolderName and AccountNumber.
//readonly: 
//    Use a readonly variable AccountNumber to ensure it cannot be changed once assigned.
//is operator: 
//    Check if an account object is an instance of the BankAccount class before displaying its details.
//*/

namespace Assignment.Keywords
{
    internal class BankAccount
    {
        //static bank name and total accounts 
        public static string bankName = "Golden Bank";
        private static int totalAccounts = 0;

        //readonly variable cannot be change once declared
        public readonly string AccountNumber;

        //instance field
        public string AccountHolderName;

        //constructor
        public BankAccount(string accountHolderName, string accountNumber)
        {
            //'this' operator resolves the ambiguity 
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
            totalAccounts++;
        }

        //static method to display the total number of accounts
        public static void GetTotalAccounts()
        {
            Console.WriteLine($"Total Accounts: {totalAccounts}");
        }

        public static void DisplayAccount(object obj)
        {
            //'is' operator is used to ensure type safety
            if (obj is BankAccount acc)
            {
                Console.WriteLine($"{acc.AccountHolderName} - {acc.AccountNumber}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //create bank accounts
            BankAccount acc1 = new BankAccount("Alice Johnson", "ACC1001");
            BankAccount acc2 = new BankAccount("Bob Smith", "ACC1002");

            //display bank name (static member)
            Console.WriteLine($"Bank Name: {BankAccount.bankName}");

            //display account details using static method
            BankAccount.DisplayAccount(acc1);
            BankAccount.DisplayAccount(acc2);

            //display total number of accounts
            BankAccount.GetTotalAccounts();

            Console.ReadLine();
        }
    }

}
