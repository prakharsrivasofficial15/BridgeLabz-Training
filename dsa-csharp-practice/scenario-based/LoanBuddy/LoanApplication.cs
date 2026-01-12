using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanBuddy
{
    public abstract class LoanApplication : Applicant, IApprovable
    {
        protected int Term; // months
        protected double InterestRate;
        protected string LoanType;
        protected bool LoanStatus { get; set; }

        protected LoanApplication(string name, int creditScore, double income, double loanAmount, int term, double interestRate, string loanType) : base(name, creditScore, income, loanAmount)
        {
            Term = term;
            InterestRate = interestRate;
            LoanType = loanType;
        }

        public virtual bool ApproveLoan()
        {
            LoanStatus = IsCreditEligible() && Income >= LoanAmount * 0.3;
            return LoanStatus;
        }

        public abstract double CalculateEMI();
    }

}
