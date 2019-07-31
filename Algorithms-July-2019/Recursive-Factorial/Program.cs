using System;

namespace Recursive_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(i));
        }

        private static long Factorial(int i)
        {
           if (i == 1)
           {
               return 1;
           }

           return Factorial(i - 1) * i;
        }
    }
}
