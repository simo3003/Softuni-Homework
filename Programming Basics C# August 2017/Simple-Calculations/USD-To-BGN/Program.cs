using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var usd = double.Parse(Console.ReadLine());
            var bgn = 1.79549 * usd;
            bgn = Math.Round(bgn, 2);
            Console.WriteLine(bgn);
        }
    }
}
