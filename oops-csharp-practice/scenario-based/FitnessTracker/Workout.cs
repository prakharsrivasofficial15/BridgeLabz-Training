using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Scenario.FitnessTracker
{
    public abstract class Workout : ITrackable
    {
        public DateTime Date { get; set; }
        public List<Exercise> Exercises { get; set; }

        protected Workout()
        {
            Date = DateTime.Now;
            Exercises = new List<Exercise>();
        }

        public int GetTotalWorkoutTime()
        {
            int total = 0;
            for (int i = 0; i < Exercises.Count; i++)
            {
                total += Exercises[i].TimeInMinutes;
            }
            return total;
        }

        public abstract void TrackProgress();
        public abstract double CalculateCalories();
    }

}