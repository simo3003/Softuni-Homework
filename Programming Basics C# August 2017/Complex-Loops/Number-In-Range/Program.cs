using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_In_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool inRange = n >= 1 && n <= 100;
            while (!inRange)
            {
                Console.WriteLine("Invalid Number");
                n = int.Parse(Console.ReadLine());
                if (n >= 1 && n <= 100)
                {
                    inRange = true;
                }


            }
            Console.WriteLine(n);
        }
    }
}
