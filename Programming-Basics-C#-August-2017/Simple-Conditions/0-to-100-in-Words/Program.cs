using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_to_100_in_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int a1;
            int a10;
            a1 = a % 10;
            a10 = a / 10;
            if (a < 0 || a > 100)
            {
                Console.WriteLine("invalid number");
            }
            if (a == 100)
            {
                Console.WriteLine("one hundred");
            }
            if (a < 20 )
            {
                if (a == 0)
                {
                    Console.WriteLine("zero");
                }
                if (a == 1)
                {
                    Console.WriteLine("one");
                }
                if (a == 2)
                {
                    Console.WriteLine("two");
                }
                if (a == 3)
                {
                    Console.WriteLine("three");
                }
                if (a == 4)
                {
                    Console.WriteLine("four");
                }
                if (a == 5)
                {
                    Console.WriteLine("five");
                }
                if (a == 6)
                {
                    Console.WriteLine("six");
                }
                if (a == 7)
                {
                    Console.WriteLine("seven");
                }
                if (a == 8)
                {
                    Console.WriteLine("eight");
                }
                if (a == 9)
                {
                    Console.WriteLine("nine");
                }
                if (a == 10)
                {
                    Console.WriteLine("ten");
                }
                if (a == 11)
                {
                    Console.WriteLine("eleven");
                }
                if (a == 12)
                {
                    Console.WriteLine("twelve");
                }
                if (a == 13)
                {
                    Console.WriteLine("thirteen");
                }
                if (a == 14)
                {
                    Console.WriteLine("fourteen");
                }
                if (a == 15)
                {
                    Console.WriteLine("fifteen");
                }
                if (a == 16)
                {
                    Console.WriteLine("sixteen");
                }
                if (a == 17)
                {
                    Console.WriteLine("seventeen");
                }
                if (a == 18)
                {
                    Console.WriteLine("eighteen");
                }
                if (a == 19)
                {
                    Console.WriteLine("nineteen");
                }
            }
            if (a >= 20 && a < 100)
            {
                if (a10 == 2)
                {
                    Console.Write("twenty");
                }
                if (a10 == 3)
                {
                    Console.Write("thirty");
                }
                if (a10 == 4)
                {
                    Console.Write("forty");
                }
                if (a10 == 5)
                {
                    Console.Write("fifty");
                }
                if (a10 == 6)
                {
                    Console.Write("sixty");
                }
                if (a10 == 7)
                {
                    Console.Write("seventy");
                }
                if (a10 == 8)
                {
                    Console.Write("eighty");
                }
                if (a10 == 9)
                {
                    Console.Write("ninety");
                }
                if (a1 == 0)
                {
                    Console.WriteLine("");
                }
                if (a1 == 1)
                {
                    Console.WriteLine(" one");
                }
                if (a1 == 2)
                {
                    Console.WriteLine(" two");
                }
                if (a1 == 3)
                {
                    Console.WriteLine(" three");
                }
                if (a1 == 4)
                {
                    Console.WriteLine(" four");
                }
                if (a1 == 5)
                {
                    Console.WriteLine(" five");
                }
                if (a1 == 6)
                {
                    Console.WriteLine(" six");
                }
                if (a1 == 7)
                {
                    Console.WriteLine(" seven");
                }
                if (a1 == 8)
                {
                    Console.WriteLine(" eight");
                }
                if (a1 == 9)
                {
                    Console.WriteLine(" nine");
                }
            }
        }
    }
}
