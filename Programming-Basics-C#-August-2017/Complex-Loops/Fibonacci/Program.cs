using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int f0 = 1;
            int f1 = 1;
            int result = 0;
            for (int i = 2; i <= n; i++)
            {
                result = f0 + f1;
                f0 = f1;
                f1 = result;
            }
            Console.WriteLine(f1);
        }
    }
}
