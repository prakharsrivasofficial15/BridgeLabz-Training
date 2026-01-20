using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.PersonalizedMealPlan
{
    class KetoMeal : IMealPlan
    {
        public string MealName => "Keto Meal";
        public int Calories { get; }

        public KetoMeal(int calories)
        {
            Calories = calories;
        }

        public void Display()
        {
            Console.WriteLine($"{MealName} - Calories: {Calories}");
        }
    }
}
