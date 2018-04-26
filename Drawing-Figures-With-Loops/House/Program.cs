using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = n;
            int stars = 1;
            if(n%2 == 2)
            {
                stars++;
            }
            for (int i = 0; i < (n+1)/2; i++)
            {
                string dashes = new string('-', (width - stars) /2);
                string starsS = new string('*', stars);
                stars += 2;
                Console.WriteLine("{0}{1}{0}", dashes, starsS);
            }
            for (int i = 0; i < n - (n + 1) / 2; i++)
            {
                Console.WriteLine("|{0}|",new string ('*', n-2));
            }
        }
    }
}
