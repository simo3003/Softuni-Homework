using System;

namespace Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalCalories = 0;
            string ingredient = "";
            int i = 0;
            while (i<=n)
            {
                switch (ingredient.ToLower())
                {
                    case "cheese":
                        totalCalories += 500;
                        break;
                    case "tomato sauce":
                        totalCalories += 150;
                        break;
                    case "salami":
                        totalCalories += 600;
                        break;
                    case "pepper":
                        totalCalories += 50;
                        break;
                    default:
                        break;
                }
                ingredient = Console.ReadLine();
                i++;
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
