using System;

namespace Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            bool[] primes = new bool[n+1];
            for (long i = 0; i < primes.Length; i++)
            {
                primes[i] = true;
            }
            primes[0] = false;
            primes[1] = false;
            for (long i = 2; i < primes.Length; i++)
            {
                if (primes[i])
                {
                    Console.Write(i + " ");
                    for (long j = 2 * i; j < primes.Length; j += i)
                    {
                        primes[j] = false;
                    }
                }
            }
        }
    }
}
