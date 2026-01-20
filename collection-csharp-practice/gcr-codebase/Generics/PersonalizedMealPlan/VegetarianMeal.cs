using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.PersonalizedMealPlan
{
    class VegetarianMeal : IMealPlan
    {
        public string MealName => "Vegetarian Meal";
        public int Calories { get; }

        public VegetarianMeal(int calories)
        {
            Calories = calories;
        }

        public void Display()
        {
            Console.WriteLine($"{MealName} - Calories: {Calories}");
        }
    }
}

