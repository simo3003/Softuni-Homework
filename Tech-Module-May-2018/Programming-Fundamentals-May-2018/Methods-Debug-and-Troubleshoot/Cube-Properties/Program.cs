using System;

namespace Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            Console.WriteLine($"{Calculate(input, type):f2}");
        }

        static double Calculate(double input, string type)
        {
            double result = 0;
            switch (type)
            {
                case "space":
                    return Math.Sqrt(input * input + input * input + input * input);
                case "face":
                    return Math.Sqrt(input * input + input * input);
                case "volume":
                    return input * input * input;
                case "area":
                    return 6 * input * input;
            }
            return result;
        }
    }
}
