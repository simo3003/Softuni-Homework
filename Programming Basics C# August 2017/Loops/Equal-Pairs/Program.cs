using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentPair = 0;
            int lastPair = 0;
            int maxDiff = 0;
            for (int i = 0; i < n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                currentPair = num1 + num2;
                if (i > 0)
                {
                    if (lastPair != currentPair)
                    {
                        int Diff = Math.Abs(lastPair - currentPair);
                        if (Diff > maxDiff)
                        {
                            maxDiff = Diff;
                        }
                    }
                }
                lastPair = currentPair;
            }
            if(maxDiff == 0)
            {
                Console.WriteLine("Yes, value = {0}",lastPair);
            }
            else
            {
                Console.WriteLine("No, maxDiff = {0}", maxDiff);
            }
        }
    }
}
