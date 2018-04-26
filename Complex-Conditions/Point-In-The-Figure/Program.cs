using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_In_The_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            if ((x < 0 || x > 3 * h) || (y < 0 || y > 4 * h) || (x < h && y > h) || (x <= h && y > 4*h) || (x >= h && y > 4 * h) || (x > 2 * h && y > h) || (x > h && x < 2 * h && y > 4 * h))
            {
                Console.WriteLine("outside");
            }
            else if (y > 0 && y < h && x < 3 * h && x > 0)
            {
                Console.WriteLine("inside");
            }
            else if (y < 4 * h && y > 0 && x > h && x < 2*h)
            {
                Console.WriteLine("inside");
            }
            else if(x == h && y <= 2*h && y >= h)
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("border");
            }
        }
    }
}
