using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            int numbers;
            int min = int.MaxValue;
            for (int n = 0; n < a; n++)
            {
                numbers = int.Parse(Console.ReadLine());
                if (numbers < min)
                {
                    min = numbers;
                }
            }
            Console.WriteLine(min);
        }
    }
}
