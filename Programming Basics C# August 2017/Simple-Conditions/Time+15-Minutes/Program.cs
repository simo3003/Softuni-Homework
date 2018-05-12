using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            b = b + 15;
            if (b > 59)
            {
                a++;
                b = b - 60;
            }
            if (a > 23)
            {
                a = 0;
            }
            Console.Write("{0}:", a);
            if (b < 10)
            {
                Console.Write("0{0}", b);
            }
            else
            {
                Console.Write(b);
            }
        }
    }
}
