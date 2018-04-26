using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blanket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 3 * n;
            int height = 2 * n + 8;
            int dotCount = width - 1;
            int xCount = 1;
            string dot = new string('.', dotCount/2);
            string x = new string('x', xCount);
            Console.WriteLine($"{dot}x{dot}");
            dotCount = width - 3;
            dot = new string('.', dotCount / 2);
            Console.WriteLine($"{dot}/x\\{dot}");
            Console.WriteLine($"{dot}x|x{dot}");
            xCount = n;
            x = new string('x', xCount);
            dotCount = (width - 2*n -1) / 2;
            new string('.', dotCount / 2);
            for (int i = 1; i <=n; i++)
            {
                if (i == (n+1)/2)
                {
                    x = new string('x', xCount);
                    Console.WriteLine($"{x}|{x}");
                    continue;
                }
                if (i>(n+1)/2)
                {
                    xCount--;
                    dotCount++;
                    dot = new string('.', dotCount);
                    x = new string('x', xCount);
                    Console.WriteLine($"{dot}{x}|{x}{dot}");
                    continue;
                }
                dot = new string('.', dotCount);
                x = new string('x', xCount);
                Console.WriteLine($"{dot}{x}|{x}{dot}");
                xCount++;
                dotCount--;
            }
            //Console.WriteLine(xCount); //5  pri 5
            //Console.WriteLine(dotCount); // 2 pri 5
            dotCount = (width-3)/2;
            xCount = 1;
            x = new string('x', xCount);
            dot = new string('.', dotCount);
            Console.WriteLine($"{dot}/{x}\\{dot}");
            Console.WriteLine($"{dot}\\{x}/{dot}");
            xCount = n;
            x = new string('x', xCount);
            dotCount = (width - 2 * n - 1) / 2;
            new string('.', dotCount / 2);
            for (int i = 1; i <= n; i++)
            {
                if (i == (n + 1) / 2)
                {
                    x = new string('x', xCount);
                    Console.WriteLine($"{x}|{x}");
                    continue;
                }
                if (i > (n + 1) / 2)
                {
                    xCount--;
                    dotCount++;
                    dot = new string('.', dotCount);
                    x = new string('x', xCount);
                    Console.WriteLine($"{dot}{x}|{x}{dot}");
                    continue;
                }
                dot = new string('.', dotCount);
                x = new string('x', xCount);
                Console.WriteLine($"{dot}{x}|{x}{dot}");
                xCount++;
                dotCount--;
            }
            dotCount = width - 3;
            dot = new string('.', dotCount / 2);
            Console.WriteLine($"{dot}x|x{dot}");
            Console.WriteLine($"{dot}\\x/{dot}");
            dotCount = width - 1;
            dot = new string('.', dotCount / 2);
            Console.WriteLine($"{dot}x{dot}");
        }
    }
}
