using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Policy
    {
        public string PolicyNumber { get; set; }
        public string CoverageType { get; set; }
        public DateTime ExpiryDate { get; set; }

        public override int GetHashCode()
        {
            return PolicyNumber.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Policy p = obj as Policy;
            return p != null && p.PolicyNumber == PolicyNumber;
        }
    }

    class InsurancePolicy
    {
        static void Main()
        {
            HashSet<Policy> uniquePolicies = new HashSet<Policy>();
            LinkedList<Policy> insertionOrder = new LinkedList<Policy>();
            SortedSet<Policy> sortedByExpiry = new SortedSet<Policy>(
                Comparer<Policy>.Create((a, b) => a.ExpiryDate.CompareTo(b.ExpiryDate))
            );

            Console.Write("Enter number of policies: ");
            int n = int.Parse(Console.ReadLine());

            // Take policy input from user
            for (int i = 0; i < n; i++)
            {
                Policy p = new Policy();

                Console.Write("Enter Policy Number: ");
                p.PolicyNumber = Console.ReadLine();

                Console.Write("Enter Coverage Type: ");
                p.CoverageType = Console.ReadLine();

                Console.Write("Enter Expiry Date (yyyy-mm-dd): ");
                p.ExpiryDate = DateTime.Parse(Console.ReadLine());

                // Add only unique policies
                if (uniquePolicies.Add(p))
                {
                    insertionOrder.AddLast(p);
                }

                sortedByExpiry.Add(p);
            }

            Console.WriteLine("\nPolicies expiring within 30 days:");
            DateTime today = DateTime.Now;

            foreach (Policy p in sortedByExpiry)
            {
                int daysLeft = (p.ExpiryDate - today).Days;
                if (daysLeft <= 30)
                {
                    Console.WriteLine(p.PolicyNumber + " - " + p.ExpiryDate.ToShortDateString());
                }
            }

            Console.ReadLine();
        }
    }
}
