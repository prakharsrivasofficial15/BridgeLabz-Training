using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Scenario.FitnessTracker
{
    public class CardioWorkout : Workout
    {
        public CardioWorkout()
        {
            Exercises.Add(new Exercise("Jumping Jacks", 10));
            Exercises.Add(new Exercise("Running", 30));
            Exercises.Add(new Exercise("High Knees", 5));
        }

        public override void TrackProgress()
        {
            Console.WriteLine("Cardio Workout:");
            for(int i=0; i<Exercises.Count; i++)
            {
                Console.WriteLine($"{Exercises[i].Name} - {Exercises[i].TimeInMinutes} minutes");
            }

            Console.WriteLine("Total Cardio Time in minutes: " + GetTotalWorkoutTime());
        }

        private const double CaloriesPerMinute = 8.0;

        public override double CalculateCalories()
        {
            return GetTotalWorkoutTime() * CaloriesPerMinute;
        }
    }

}
