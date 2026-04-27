using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Scenario.FitnessTracker
{
    public class StrengthWorkout : Workout
    {
        public StrengthWorkout()
        {
            Exercises.Add(new Exercise("Push-Ups", 15));
            Exercises.Add(new Exercise("Squats", 15));
            Exercises.Add(new Exercise("Plank", 5));
            Exercises.Add(new Exercise("Dumbbell Curls", 15));
        }

        public override void TrackProgress()
        {
            Console.WriteLine("Strength Workout");
            for(int i=0; i<Exercises.Count; i++)
            {
                Console.WriteLine($"{Exercises[i].Name} - {Exercises[i].TimeInMinutes} minutes");
            }

            Console.WriteLine($"Total Strength Time: {GetTotalWorkoutTime()} minutes");
        }

        private const double CaloriesPerMinute = 6.0;

        public override double CalculateCalories()
        {
            return GetTotalWorkoutTime() * CaloriesPerMinute;
        }

    }

}
