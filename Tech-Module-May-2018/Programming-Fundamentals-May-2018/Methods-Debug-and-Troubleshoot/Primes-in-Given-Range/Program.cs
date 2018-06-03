using System;
using System.Collections.Generic;

namespace Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            List<int> primeNumbers = FindPrimesInGivenRange(startNum, endNum);
            Console.WriteLine(String.Join(", ", primeNumbers));
        }
        static List<int> FindPrimesInGivenRange(int startNum, int endNum)
        {
            List<int> primeNumbers = new List<int>();
            int currentNum = startNum;
            while (currentNum <= endNum)
            {
                int i = 2;
                bool isPrime = true;
                if (currentNum % 2 == 0 || currentNum == 0 || currentNum == 1)
                {
                    isPrime = false;
                }
                if (currentNum == 2)
                {
                    isPrime = true;
                }
                while (i <= Math.Sqrt(currentNum))
                {
                    if (currentNum % i == 0) isPrime = false;
                    i++;
                }
                if (isPrime)
                {
                    primeNumbers.Add(currentNum);
                }
                currentNum++;
            }
            return primeNumbers;
        }
    }
}
