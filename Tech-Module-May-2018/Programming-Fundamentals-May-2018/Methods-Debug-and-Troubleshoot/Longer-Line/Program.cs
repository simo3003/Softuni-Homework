using System;

namespace Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            // first line
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            // second line
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            Console.WriteLine(CalculateLongerLine(x1, y1, x2, y2, x3, y3, x4, y4));
        }

        static string CalculateLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double firstLine = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            double secondLine = Math.Sqrt(Math.Pow(x3 - x4, 2) + Math.Pow(y3 - y4, 2));
            if (firstLine >= secondLine)
            {
                return (IsFirstPointCloserToCenter(x1, y1, x2, y2)) ? $"({x1}, {y1})({x2}, {y2})" : $"({x2}, {y2})({x1}, {y1})";
            }
            else
            {
                return (IsFirstPointCloserToCenter(x3, y3, x4, y4)) ? $"({x3}, {y3})({x4}, {y4})" : $"({x4}, {y4})({x3}, {y3})";
            }
        }
        static bool IsFirstPointCloserToCenter(double x1, double y1, double x2, double y2)
        {
            double firstDiff = Math.Sqrt(x1 * x1 + y1 * y1);
            double secondDiff = Math.Sqrt(x2 * x2 + y2 * y2);
            return firstDiff <= secondDiff;
        }
    }
}
