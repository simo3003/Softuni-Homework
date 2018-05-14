using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_Of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int space = 0; space < n-row; space++)
                {
                    Console.Write(" ");
                }
                for (int a = 1; a <= row; a++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= n-1; i++)
            {
                for (int space = 0; space < i; space++)
                {
                    Console.Write(" ");
                }
                for (int a = 0; a < n-i; a++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
