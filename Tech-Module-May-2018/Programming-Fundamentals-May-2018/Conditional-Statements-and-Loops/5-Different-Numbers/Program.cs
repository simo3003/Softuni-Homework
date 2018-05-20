using System;

namespace _5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (b-a < 5)
            {
                Console.WriteLine("No");
                return;
            }
            for (int i = a; i <= b; i++)
            {
                for (int j = a+1; j <= b; j++)
                {
                    for (int k = a+2; k <= b; k++)
                    {
                        for (int l = a+3; l <= b; l++)
                        {
                            for (int m = a+4; m <= b; m++)
                            {
                                if (i < j && j < k && k < l && l < m)
                                {
                                    Console.WriteLine($"{i} {j} {k} {l} {m}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
