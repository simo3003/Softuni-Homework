using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int min = Math.Min(a, b);
            int max = Math.Max(a, b);
            while (min != 0)
            {
                int newMin = max % min;
                max = min;
                min = newMin;
                
            }
            Console.WriteLine(max);
            //for (int i = 2; i <= min; i++)
            //{
            //    if (a % i == 0 && b % i == 0)
            //    {
            //        gcd = i;
            //    }
            //}
            //Console.WriteLine(gcd);

        }
    }
}
