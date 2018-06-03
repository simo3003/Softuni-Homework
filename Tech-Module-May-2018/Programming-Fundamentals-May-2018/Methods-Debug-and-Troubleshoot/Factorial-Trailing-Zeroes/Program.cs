using System;
using System.Numerics;
namespace Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result = Factorial(n);
            int counter = 0;
            for (int i = result.Length-1; i >= 0; i--)
            {
                if (int.Parse(result[i].ToString()) != 0)
                {
                    break;
                }
                else
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
        static string Factorial(int n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial.ToString();
        }
    }
}
