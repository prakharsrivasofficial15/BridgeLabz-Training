using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanBuddy
{
    public class PersonalLoan : LoanApplication
    {
        public PersonalLoan(string name, int creditScore, double income, double loanAmount) : base(name, creditScore, income, loanAmount, 36, 0.12, "Personal Loan") { }

        public override double CalculateEMI()
        {
            double r = InterestRate / 12;
            return LoanAmount * r * Math.Pow(1 + r, Term) / (Math.Pow(1 + r, Term) - 1);
        }
    }

}
