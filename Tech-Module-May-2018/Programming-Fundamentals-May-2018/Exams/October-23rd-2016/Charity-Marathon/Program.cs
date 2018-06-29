using System;

namespace Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            long days = long.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            long avgLaps = long.Parse(Console.ReadLine());
            long length = long.Parse(Console.ReadLine());
            long capacity = long.Parse(Console.ReadLine()) * days;
            double moneyPerKilometer = double.Parse(Console.ReadLine());
            if (runners > capacity)
                runners = capacity;
            long totalKilometers = (runners * avgLaps * length) / 1000;
            Console.WriteLine($"Money raised: {totalKilometers*moneyPerKilometer:f2}");
        }
    }
}
