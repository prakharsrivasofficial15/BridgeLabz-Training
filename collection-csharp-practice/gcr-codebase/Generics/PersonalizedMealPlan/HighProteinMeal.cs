using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.PersonalizedMealPlan
{
    class HighProteinMeal : IMealPlan
    {
        public string MealName => "High Protein Meal";
        public int Calories { get; }

        public HighProteinMeal(int calories)
        {
            Calories = calories;
        }

        public void Display()
        {
            Console.WriteLine($"{MealName} - Calories: {Calories}");
        }
    }
}
