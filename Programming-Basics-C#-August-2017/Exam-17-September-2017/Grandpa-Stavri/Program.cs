using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grandpa_Stavri
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double currentLiters;
            double currentDegrees;
            double total = 0;
            double sumLiters = 0;
            double sumDegrees = 0;
            for (int i = 1; i <= n; i++)
            {
                currentLiters = double.Parse(Console.ReadLine());
                currentDegrees = double.Parse(Console.ReadLine());
                sumLiters = sumLiters + currentLiters;
                total = total + (currentDegrees * currentLiters);
            }
            sumDegrees = total / sumLiters;
            Console.WriteLine($"Liter: {sumLiters:f2}");
            Console.WriteLine($"Degrees: {sumDegrees:f2}");
            if (sumDegrees<38)
            {
                Console.WriteLine("Not good, you should baking!"); 
            }
            else if (sumDegrees>=38 && sumDegrees <= 42)
            {
                Console.WriteLine("Super!");
            }
            else if (sumDegrees>42)
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
