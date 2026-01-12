using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanBuddy
{
    public class LoanMenu
    {
        public void Start()
        {
            Console.WriteLine("Welcome to LoanBuddy");

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Credit Score: ");
            int creditScore = int.Parse(Console.ReadLine());

            Console.Write("Enter Monthly Income: ");
            double income = double.Parse(Console.ReadLine());

            Console.Write("Enter Loan Amount: ");
            double loanAmount = double.Parse(Console.ReadLine());

            Console.WriteLine("\nSelect Loan Type:");
            Console.WriteLine("1. Home Loan");
            Console.WriteLine("2. Auto Loan");
            Console.WriteLine("3. Personal Loan");

            Console.Write("Enter Your Choice: ");
            int choice = int.Parse(Console.ReadLine());

            LoanApplication loan = null;

            switch (choice)
            {
                case 1:
                    loan = new HomeLoan(name, creditScore, income, loanAmount);
                    break;

                case 2:
                    loan = new AutoLoan(name, creditScore, income, loanAmount);
                    break;

                case 3:
                    loan = new PersonalLoan(name, creditScore, income, loanAmount);
                    break;

                default:
                    Console.WriteLine("Invalid");
                    return;
            }

            ProcessLoan(loan);
        }

        private void ProcessLoan(IApprovable loan)
        {
            Console.WriteLine("Processing Loan Application");

            if (loan.ApproveLoan())
            {
                Console.WriteLine("Loan Approved");
                Console.WriteLine($"Monthly EMI: {loan.CalculateEMI():0.00}");
            }
            else
            {
                Console.WriteLine("Loan Rejected");
            }
        }
    }
}
