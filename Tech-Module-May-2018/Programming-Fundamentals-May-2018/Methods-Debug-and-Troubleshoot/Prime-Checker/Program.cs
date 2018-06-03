using System;

namespace Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(n));
        }

        static bool IsPrime(long n)
        {
            if (n == 2)
            {
                return true;
            }
            if (n % 2 == 0 || n == 0 || n == 1)
            {
                return false;
            }
            long i = 2;
            while (i <= Math.Sqrt(n))
            {
                if (n % i == 0)
                    return false;
                i++;
            }
            return true;
        }
    }
}
