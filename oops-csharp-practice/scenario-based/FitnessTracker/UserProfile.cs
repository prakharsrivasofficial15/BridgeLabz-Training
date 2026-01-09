using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Scenario.FitnessTracker
{
    public class UserProfile
    {
        public string UserName { get; set; }
        private List<Workout> workouts;

        public UserProfile(string userName)
        {
            UserName = userName;
            workouts = new List<Workout>();
        }

        public void AddWorkout(Workout workout)
        {
            workouts.Add(workout);
            Console.WriteLine("Workout added successfully");
        }

        public void ShowWorkouts()
        {
            for (int i = 0; i < workouts.Count; i++)
            {
                workouts[i].TrackProgress();
                Console.WriteLine();
            }
        }
    }

}
