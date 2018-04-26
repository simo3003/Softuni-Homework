using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            double b=0;
            if (a <= 100)
            {
                b = 5;
            }
            if (a > 100 && a < 1000)
            {
                b = 0.2 * a + b;
            }
            if (a > 1000 && a > 100)
            {
                b = 0.1 * a + b;
            }
            if (a % 2 == 0)
            {
                b++;
            }
            if (a % 10 == 5)
            {
                b = b + 2;
            }
            Console.WriteLine(b);
            Console.WriteLine(b + a);
        }
    }
}
