using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double number;
            double oddSum = 0;
            double oddMin = int.MaxValue;
            double oddMax = int.MinValue;
            double evenSum = 0;
            double evenMin = int.MaxValue;
            double evenMax = int.MinValue;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    number = double.Parse(Console.ReadLine());
                    oddSum = oddSum + number;
                    if (number < oddMin)
                    {
                        oddMin = number;
                    }
                    if (number > oddMax)
                    {
                        oddMax = number;
                    }
                }
                else if (i % 2 == 0)
                {
                    number = double.Parse(Console.ReadLine());
                    evenSum = evenSum + number;
                    if (number < evenMin)
                    {
                        evenMin = number;
                    }
                    if (number > evenMax)
                    {
                        evenMax = number;
                    }
                }
            }
            Console.WriteLine("OddSum = {0}", oddSum);
            if (oddMin == int.MaxValue)
            {
                Console.WriteLine("OddMin = No");
            }
            else
            {
                Console.WriteLine("OddMin = {0}", oddMin);
            }
            if (oddMax == int.MinValue)
            {
                Console.WriteLine("OddMax = No");
            }
            else
            {
                Console.WriteLine("OddMax = {0}", oddMax);
            }
            Console.WriteLine("EvenSum = {0}", evenSum);
            if (evenMin == int.MaxValue)
            {
                Console.WriteLine("EvenMin = No");
            }
            else
            {
                Console.WriteLine("EvenMin = {0}", evenMin);
            }
            if (evenMax == int.MinValue)
            {
                Console.WriteLine("EvenMax = No");
            }
            else
            {
                Console.WriteLine("EvenMax = {0}", evenMax);
            }
        }
    }
}
