using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());
            int volume = length * width * height;
            double voluneInLiters = volume * 0.001;
            double percentageOk = percentage * 0.01;
            double water = voluneInLiters * (1 - percentageOk);
            Console.WriteLine($"{water:f3}");

        }
    }
}
