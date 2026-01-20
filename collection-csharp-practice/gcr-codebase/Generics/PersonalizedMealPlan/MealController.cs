using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.PersonalizedMealPlan
{
    class MealController
    {
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\nPersonalized Meal Plan Generator");
                Console.WriteLine("1. Vegetarian");
                Console.WriteLine("2. Vegan");
                Console.WriteLine("3. Keto");
                Console.WriteLine("4. High Protein");
                Console.WriteLine("5. Exit");

                Console.Write("Choose meal type: ");
                int choice = int.Parse(Console.ReadLine());

                Console.Write("Enter calories: ");
                int calories = int.Parse(Console.ReadLine());

                try
                {
                    switch (choice)
                    {
                        case 1:
                            MealGenerator.GenerateMeal(new VegetarianMeal(calories)).ShowMeal();
                            break;

                        case 2:
                            MealGenerator.GenerateMeal(new VeganMeal(calories)).ShowMeal();
                            break;

                        case 3:
                            MealGenerator.GenerateMeal(new KetoMeal(calories)).ShowMeal();
                            break;

                        case 4:
                            MealGenerator.GenerateMeal(new HighProteinMeal(calories)).ShowMeal();
                            break;

                        case 5:
                            return;

                        default:
                            Console.WriteLine("Invalid choice!");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
