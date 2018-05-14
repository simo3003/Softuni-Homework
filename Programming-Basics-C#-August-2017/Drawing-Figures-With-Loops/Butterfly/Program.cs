using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = 2*(n - 2) + 1;
            int width = 2 * n - 1;
            int sideWidth = n - 1;
            char symbol = '*';
            for (int i = 0; i < n-2; i++)
            {
                if(i%2==0)
                {
                    symbol = '*';
                }
                else
                {
                    symbol = '-';
                }
                Console.WriteLine("{0}\\ /{0}", new string (symbol, sideWidth - 1));
            }
            Console.WriteLine("{0}@", new string(' ', sideWidth));
            for (int i = 0 ; i < n - 2; i++)
            {
                if (i % 2 == 0)
                {
                    symbol = '*';
                }
                else
                {
                    symbol = '-';
                }
                Console.WriteLine("{0}/ \\{0}", new string(symbol, sideWidth - 1));
            }

        }
    }
}
