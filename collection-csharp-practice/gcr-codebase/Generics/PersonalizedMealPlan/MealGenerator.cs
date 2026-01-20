using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.PersonalizedMealPlan
{
    class MealGenerator
    {
        public static Meal<T> GenerateMeal<T>(T plan) where T : IMealPlan
        {
            if (plan.Calories <= 0)
            {
                throw new Exception("Calories must be greater than zero.");
            }

            return new Meal<T>(plan);
        }
    }
}
