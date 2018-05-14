using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{0}", new string('*', 2*n), new string (' ',n));
            string slashes = new string('/', n * 2 - 2);
            string spaces = new string(' ', n);
            string pipes = new string('|', n);
            for (int i = 0; i < n-2; i++)
            {
                if (n%2==0 && i == n / 2 - 2 || (n % 2 == 1 && i == n / 2 - 1))
                {
                    Console.WriteLine($"*{slashes}*{pipes}*{slashes}*");                 
                }
                else
                {
                    Console.WriteLine($"*{slashes}*{spaces}*{slashes}*");
                }
              
            }
            Console.Write("{0}{1}{0}", new string('*', 2 * n), new string(' ', n));
        }
    }
}
