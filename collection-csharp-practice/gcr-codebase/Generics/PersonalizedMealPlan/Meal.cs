using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.PersonalizedMealPlan
{
    class Meal<T> where T : IMealPlan
    {
        public T Plan { get; }

        public Meal(T plan)
        {
            Plan = plan;
        }

        public void ShowMeal()
        {
            Plan.Display();
        }
    }
}
