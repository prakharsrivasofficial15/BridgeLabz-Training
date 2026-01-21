using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class VotingSystem
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> votes = new Dictionary<string, int>();
            SortedDictionary<string, int> sortedResults = new SortedDictionary<string, int>();
            LinkedList<string> voteOrder = new LinkedList<string>();

            Console.Write("Enter number of votes: ");
            int n = int.Parse(Console.ReadLine());

            // Take votes from user
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter candidate name: ");
                string name = Console.ReadLine();

                if (!votes.ContainsKey(name))
                {
                    votes[name] = 0;
                }

                votes[name]++;

                voteOrder.AddLast(name);
            }

            // Sort results alphabetically
            foreach (var kv in votes)
            {
                sortedResults[kv.Key] = kv.Value;
            }

            // Display results
            Console.WriteLine("Voting Results:");
            foreach (var kv in sortedResults)
            {
                Console.WriteLine($"{kv.Key} : {kv.Value}");
            }

            Console.ReadLine();
        }
    }
}