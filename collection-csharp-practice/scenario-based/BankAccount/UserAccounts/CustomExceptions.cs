using System;

namespace BankAccount.UserAccounts
{
    public class NotValidAmountException: Exception
    {
        public decimal Amount{get;}

        public NotValidAmountException(string message, decimal amount):base(message)
        {
            Amount = amount;
        } 
    }

    public class NotSufficentFunds : Exception
    {
        public decimal Amount {get;}

        public NotSufficentFunds(string message, decimal amount) : base(message)
        {
            Amount = amount;
        }
    }
}