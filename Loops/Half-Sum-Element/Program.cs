using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] num = new int [n];
            int sum = 0;
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
             if(i == 0 )
                {
                    max = num[i];
                }
             else if(num[i] > max)
                {
                    max = num[i];
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (num[i] == max)
                {
                    num[i] = 0;
                    break;
                }
            }
            for (int i = 0; i < n; i++)
            {
                sum = sum + num[i];
            }
            if(max == sum)
            {
                Console.WriteLine("Yes, Sum = {0}", sum);
            }
            else
            {
                Console.WriteLine("No, Diff = {0}", Math.Abs(max - sum));
            }

        }
    }
}
