using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Scenario.FitnessTracker
{
    class Entry
    {
        static void Main()
        {
            Console.Write("Enter User Name: ");
            UserProfile user = new UserProfile(Console.ReadLine());

            int choice;
            while(true) {
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Cardio Workout");
                Console.WriteLine("2. Strength Workout");
                Console.WriteLine("3. View Workout Details");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Workout cardio = new CardioWorkout();
                        cardio.TrackProgress();
                        user.AddWorkout(cardio);
                        break;

                    case 2:
                        Workout strength = new StrengthWorkout();
                        strength.TrackProgress();
                        user.AddWorkout(strength);
                        break;

                    case 3:
                        user.ShowWorkouts();
                        break;

                    case 4:
                        Console.WriteLine("Exit");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            } 
        }
    }
}
