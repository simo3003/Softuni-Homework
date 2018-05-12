using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            int sum = a + b + c;
            int suma = sum;
            if (sum >= 0 && sum <= 59)
            {
                Console.Write("0:");
                suma = sum;
            }
            if (sum >= 60 && sum <= 119)
            {
                Console.Write("1:");
                suma = sum - 60;
            }
            if (sum >= 120 && sum <= 179)
            {
                Console.Write("2:");
                suma = sum - 120;
            }
            if (suma < 10)
            {
                Console.Write("0{0}", suma);
            }
            else
            {
                Console.WriteLine(suma);
            }
        }
    }
}
