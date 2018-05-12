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
            int numbers = 0;
            for(int n = 0;n<a;n++)
            {
                int c = int.Parse(Console.ReadLine());
                numbers = c + numbers;
            }
            Console.WriteLine(numbers);
        }
    }
}
