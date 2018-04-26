using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_Brothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double father = double.Parse(Console.ReadLine());
            double broSum = 1/(1/a + 1/b + 1/c);
            broSum = 0.15 * broSum + broSum;
            double timeLeft;
            Console.WriteLine($"Cleaning time: {broSum:f2}");
            if(broSum<father)
            {
                timeLeft = father - broSum;
                timeLeft = Math.Floor(timeLeft);
                Console.WriteLine($"Yes, there is a surprise - time left -> {timeLeft} hours.");
            }
            else
            {
                timeLeft = broSum - father;
                timeLeft = Math.Ceiling(timeLeft);
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {timeLeft} hours.");
            }
        }
    }
}
