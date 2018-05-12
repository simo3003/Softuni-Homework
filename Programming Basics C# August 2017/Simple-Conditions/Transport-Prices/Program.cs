using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Prices
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine()); // km
            string b = Console.ReadLine(); // day or night
            const double tS = 0.70; // taxi start
            const double tD = 0.79; // taxi day
            const double tN = 0.90; // taxi night
            const double bD = 0.09; // bus day
            const double bN = bD; // bus night
            const double trD = 0.06; // train day
            const double trN = trD; // train night
            double result; // final result
            if (a < 20) // taxi
            {
                if(b == "day")
                {
                    result = a * tD + tS;
                    Math.Round(result, 2);
                    Console.WriteLine(result);
                }
                if(b == "night")
                {
                    result = a * tN + tS;
                    Math.Round(result, 2);
                    Console.WriteLine(result);
                }
            }
            if (a >= 20 && a <= 100)
            {
                if (b == "day")
                {
                    result = a * bD;
                    Math.Round(result, 2);
                    Console.WriteLine(result);
                }
                if (b == "night")
                {
                    result = a * bN;
                    Math.Round(result, 2);
                    Console.WriteLine(result);
                }
            }
            if (a>=100)
            {
                if (b == "day")
                {
                    result = a * trD;
                    Math.Round(result, 2);
                    Console.WriteLine(result);
                }
                if (b == "night")
                {
                    result = a * trN;
                    Math.Round(result, 2);
                    Console.WriteLine(result);
                }
            }
        }
    }
}
