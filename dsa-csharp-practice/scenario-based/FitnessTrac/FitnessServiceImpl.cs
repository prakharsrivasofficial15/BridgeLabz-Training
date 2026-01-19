using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrac
{
    //class implements the IFitnessService interface
    class FitnessServiceImpl : IFitnessService
    {
        private User[] users = new User[20];
        private int count = 0;
        //Object of BubbleSortAlgorithm for sorting leaderboard
        private BubbleSortAlgorithm algo = new BubbleSortAlgorithm();

        public void AddUser()
        {
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Steps: ");
            int steps = int.Parse(Console.ReadLine());

            //creates new FitnessUser and add it to the array
            users[count++] = new FitnessUser(id, name, steps);
        }

        //updates steps of existing user
        public void UpdateSteps()
        {
            Console.Write("User index: ");
            int i = int.Parse(Console.ReadLine());

            Console.Write("New steps: ");
            users[i].SetSteps(int.Parse(Console.ReadLine()));
        }

        //sort user based on steps
        public void SortRanking()
        {
            algo.Sort(users, count);
            Console.WriteLine("Leaderboard updated.");
        }

        public void DisplayLeaderboard()
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine($"{i + 1}. {users[i]}");
        }
    }
}
