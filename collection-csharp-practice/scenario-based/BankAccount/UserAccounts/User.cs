using System;

namespace BankAccount.UserAccounts
{
    public class User
    {
        decimal balance;
        public decimal GetBalance() {return balance;}
        public User()
        {
            balance = 10000.00M;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new NotValidAmountException("Deposit amount cannot be negative",amount);
            }
            balance +=amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > balance)
            {
                throw new NotSufficentFunds("InSufficent balance in the account",amount);
            }
            balance -= amount;
        }
    }
}