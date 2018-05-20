using System;

namespace Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            switch (a)
            {
                case "Athlete":
                    Console.WriteLine($"The {a} has to pay {(quantity*0.70):f2}.");
                    break;
                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine($"The {a} has to pay {(quantity * 1.00):f2}.");
                    break;
                case "SoftUni Student":
                    Console.WriteLine($"The {a} has to pay {(quantity * 1.70):f2}.");
                    break;
                default:
                    Console.WriteLine($"The {a} has to pay {(quantity * 1.20):f2}.");
                    break;
            }
        }
    }
}
