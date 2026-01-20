using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.PersonalizedMealPlan
{
    class VeganMeal : IMealPlan
    {
        public string MealName => "Vegan Meal";
        public int Calories { get; }

        public VeganMeal(int calories)
        {
            Calories = calories;
        }

        public void Display()
        {
            Console.WriteLine($"{MealName} - Calories: {Calories}");
        }
    }
}
