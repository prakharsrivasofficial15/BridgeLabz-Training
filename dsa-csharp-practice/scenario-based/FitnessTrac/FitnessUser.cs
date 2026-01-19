using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrac
{
    //fitness class inherits from user
    class FitnessUser : User
    {
        //constructor passes value to the base upper class
        public FitnessUser(int id, string name, int steps) : base(id, name, steps) { }
    }

}
