using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int newN = n;
            int sum = 0;
            while (newN != 0)
            {
                sum = sum+ newN % 10;
                newN = newN / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
