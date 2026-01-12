using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanBuddy
{
    public abstract class Applicant
    {
        public string Name { get; set; }
        private int creditScore;
        public double Income { get; set; }
        public double LoanAmount { get; set; }

        protected Applicant(string name, int creditScore, double income, double loanAmount)
        {
            Name = name;
            this.creditScore = creditScore;
            Income = income;
            LoanAmount = loanAmount;
        }

        protected bool IsCreditEligible()
        {
            return creditScore >= 650;
        }
    }

}
