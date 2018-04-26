using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double result;
            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                result = a * a;
                Math.Round(result, 3);
                Console.WriteLine(result);
            }
            if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                result = a * b;
                Math.Round(result, 3);
                Console.WriteLine(result);
            }
            if (figure == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                result = a * a * Math.PI;
                Math.Round(result, 3);
                Console.WriteLine(result);
            }
            if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                result = a * b / 2;
                Math.Round(result, 3);
                Console.WriteLine(result);
            }
        }
    }
}
