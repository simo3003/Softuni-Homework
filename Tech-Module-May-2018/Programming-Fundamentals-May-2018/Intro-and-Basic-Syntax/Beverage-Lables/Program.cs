using System;

namespace Beverage_Lables
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            double energyContent = double.Parse(Console.ReadLine())* volume / 100;
            double sugarContent = double.Parse(Console.ReadLine()) * volume / 100;
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyContent}kcal, {sugarContent}g sugars");
        }
    }
}
