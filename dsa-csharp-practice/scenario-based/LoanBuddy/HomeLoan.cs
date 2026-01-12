using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanBuddy
{
    public class HomeLoan : LoanApplication
    {
        public HomeLoan(string name, int creditScore, double income, double loanAmount) : base(name, creditScore, income, loanAmount, 240, 0.08, "Home Loan")
        {
        }
        public override double CalculateEMI()
        {
            return EMIFormula();
        }
        private double EMIFormula()
        {
            double r = InterestRate / 12;
            return LoanAmount * r * Math.Pow(1 + r, Term) / (Math.Pow(1 + r, Term) - 1);
        }
    }
}
