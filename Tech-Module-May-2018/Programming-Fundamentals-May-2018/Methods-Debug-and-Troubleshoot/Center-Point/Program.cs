using System;

namespace Center_Podouble
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine(CalculateClosestToCenter(x1,y1,x2,y2));
        }

        static string CalculateClosestToCenter(double x1, double y1, double x2, double y2)
        {
            double firstDiff = Math.Sqrt(x1 * x1 + y1 * y1);
            double secondDiff = Math.Sqrt(x2 * x2 + y2 * y2);
            return (firstDiff <= secondDiff) ? $"({x1}, {y1})" : $"({x2}, {y2})";
        }
    }
}
