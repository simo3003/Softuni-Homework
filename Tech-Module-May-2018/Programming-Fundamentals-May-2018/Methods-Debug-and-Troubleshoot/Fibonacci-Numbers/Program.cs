using System;
using System.Collections.Generic;

namespace Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(n));
        }

        static long Fib(int n)
        {
            List<int> sequence = new List<int> {1,1};
            int counter = 1;
            while (counter <= n)
            {
                sequence.Add(sequence[counter] + sequence[counter-1]); // last two elements
                counter++;
            }
            return sequence[n];
        }
    }
}
