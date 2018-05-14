using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int starscount = 1;
            if (n % 2 == 0)
            {
                starscount++;
            }
            int dashescount = (n - starscount) / 2;
            string dashes = new string('-', dashescount);
            string stars = new string('*', starscount);
            Console.WriteLine("{0}{1}{0}", dashes, stars);
            for (int outerDashes  = dashescount - 1; outerDashes  >=0;  outerDashes--)
            {
               string outer = new string('-', outerDashes);
               string middle = new string('-', n - outerDashes * 2 - 2);
               Console.WriteLine($"{outer}*{middle}*{outer}");
            }
            for (int outerDashes = 1; outerDashes < (n + 1) / 2 - 1; outerDashes++)
            {
                string outer = new string('-', outerDashes);
                string middle = new string('-', n - outerDashes * 2 - 2);
                Console.WriteLine($"{outer}*{middle}*{outer}");
            }
            if(n>=3)
            {
                Console.WriteLine("{0}{1}{0}", dashes, stars);
            }
            
        }
    }
}
