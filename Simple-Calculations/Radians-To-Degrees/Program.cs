using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radians_To_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var rad = double.Parse(Console.ReadLine());
            var deg = (rad * 180) / Math.PI;
            deg = Math.Round(deg);
            Console.WriteLine(deg);
        }
    }
}
