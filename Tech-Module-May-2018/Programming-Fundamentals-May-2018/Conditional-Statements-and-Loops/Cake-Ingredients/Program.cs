using System;

namespace Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int ingredientsAmount = 0;
            while (input != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {input}.");
                ingredientsAmount++;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Preparing cake with {ingredientsAmount} ingredients.");
        }
    }
}
