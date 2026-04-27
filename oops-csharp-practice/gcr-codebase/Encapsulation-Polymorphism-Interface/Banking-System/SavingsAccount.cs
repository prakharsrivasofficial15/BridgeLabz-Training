using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Banking_System
{
    public class SavingsAccount : BankAccount, ILoanable
    {
        private const decimal InterestRate = 0.04m;

        public SavingsAccount(string accountNumber, string holderName, decimal balance)
            : base(accountNumber, holderName, balance)
        {
        }

        public override decimal CalculateInterest()
        {
            return Balance * InterestRate;
        }

        public void ApplyForLoan(decimal amount)
        {
            Console.WriteLine("Loan request of " + amount + " submitted for Savings Account.");
        }

        public bool CalculateLoanEligibility()
        {
            return Balance >= 50000;
        }
    }

}
