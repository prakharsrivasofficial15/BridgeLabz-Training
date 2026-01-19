using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrac
{
    sealed class FitnessMenu
    {
        private IFitnessService service = new FitnessServiceImpl();

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("\n1. Add User");
                Console.WriteLine("2. Update Steps");
                Console.WriteLine("3. Sort Ranking");
                Console.WriteLine("4. Show Leaderboard");
                Console.WriteLine("5. Exit");

                Console.WriteLine("Enter the choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: 
                        service.AddUser(); 
                        break;

                    case 2: 
                        service.UpdateSteps(); 
                        break;

                    case 3: 
                        service.SortRanking(); 
                        break;

                    case 4: 
                        service.DisplayLeaderboard(); 
                        break;

                    case 5: 
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }

}
