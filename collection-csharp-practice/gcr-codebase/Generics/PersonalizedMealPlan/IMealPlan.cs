using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.PersonalizedMealPlan
{
    interface IMealPlan
    {
        string MealName { get; }
        int Calories { get; }
        void Display();
    }
}