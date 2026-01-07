using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Banking_System
{
    public class BankProcessor
    {
        public static void ProcessAccounts(BankAccount[] accounts)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                BankAccount account = accounts[i];

                account.DisplayAccountDetails();

                decimal interest = account.CalculateInterest();
                Console.WriteLine("Calculated Interest: " + interest);

                // is operator + interface
                if (account is ILoanable)
                {
                    ILoanable loanableAccount = (ILoanable)account;

                    Console.WriteLine("Loan Eligibility: " +
                        (loanableAccount.CalculateLoanEligibility() ? "Eligible" : "Not Eligible"));

                    loanableAccount.ApplyForLoan(200000);
                }

            }
        }
    }

}
