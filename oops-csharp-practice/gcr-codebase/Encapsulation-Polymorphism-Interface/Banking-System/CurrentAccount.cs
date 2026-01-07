using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Banking_System
{
    public class CurrentAccount : BankAccount
    {
        private const decimal InterestRate = 0.01m;

        public CurrentAccount(string accountNumber, string holderName, decimal balance)
            : base(accountNumber, holderName, balance)
        {
        }

        public override decimal CalculateInterest()
        {
            return Balance * InterestRate;
        }

        public override void Withdraw(decimal amount)
        {
            if (amount > Balance + 10000)
                throw new InvalidOperationException("Overdraft limit exceeded");

            Balance -= amount;
        }
    }

}
