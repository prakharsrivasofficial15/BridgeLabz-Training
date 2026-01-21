using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class BankingSystem
    {
        static void Main(string[] args)
        {
            Dictionary<int, double> accounts = new Dictionary<int, double>();
            SortedDictionary<double, List<int>> sortedByBalance = new SortedDictionary<double, List<int>>();
            Queue<int> withdrawals = new Queue<int>();

            Console.Write("Enter number of accounts: ");
            int n = int.Parse(Console.ReadLine());

            //Take account details from user
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter account number: ");
                int accNo = int.Parse(Console.ReadLine());

                Console.Write("Enter balance: ");
                double balance = double.Parse(Console.ReadLine());

                accounts[accNo] = balance;
            }

            Console.Write("Enter number of withdrawals: ");
            int w = int.Parse(Console.ReadLine());

            //Take withdrawal requests
            for (int i = 0; i < w; i++)
            {
                Console.Write("Enter account number for withdrawal: ");
                int accNo = int.Parse(Console.ReadLine());
                withdrawals.Enqueue(accNo);
            }

            //Process withdrawals (fixed amount = 500)
            while (withdrawals.Count > 0)
            {
                int acc = withdrawals.Dequeue();
                if (accounts.ContainsKey(acc))
                {
                    accounts[acc] -= 500;
                }
            }

            //Sort accounts by balance
            foreach (var acc in accounts)
            {
                if (!sortedByBalance.ContainsKey(acc.Value))
                {
                    sortedByBalance[acc.Value] = new List<int>();
                }
                sortedByBalance[acc.Value].Add(acc.Key);
            }

            //Display result
            Console.WriteLine("\nCustomers sorted by balance:");
            foreach (var kv in sortedByBalance)
            {
                for (int i = 0; i < kv.Value.Count; i++)
                {
                    Console.WriteLine($"Account {kv.Value[i]} : {kv.Key}");
                }
            }

            Console.ReadLine();
        }
    }
}
