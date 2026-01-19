using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrac
{
    abstract class User
    {
        //protected variables accessible in all child classes
        protected int userId;        
        protected string name;
        protected int steps;           //stores number of steps walked
        
        //constructor to initialize user data
        public User(int id, string name, int steps)
        {
            userId = id;
            this.name = name;
            this.steps = steps;
        }

        //method to get step count
        public int GetSteps() => steps;

        //method to update the step counts
        public void SetSteps(int newSteps) { steps = newSteps; }
        //converts object data to readable format
        public override string ToString()
        {
            return $"{name} - {steps} steps";
        }
    }
}
