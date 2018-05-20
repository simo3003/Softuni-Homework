using System;

namespace Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (n % 2 == 0)
            {
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                }
            }
            Console.WriteLine($"The number is: {Math.Abs(n)}");
        }
    }
}
