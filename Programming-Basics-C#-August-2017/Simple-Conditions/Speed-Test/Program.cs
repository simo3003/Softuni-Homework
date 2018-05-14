using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            if (a <= 10) 
            {
                Console.WriteLine("slow");
            }
            if (a > 10 && a <= 50)
            {
                Console.WriteLine("average");
            }
            if (a > 50 && a <= 150)
            {
                Console.WriteLine("fast");
            }
            if (a > 150 && a <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            if (a > 1000)
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
