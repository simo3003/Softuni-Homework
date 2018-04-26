using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_And_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumLeft = 0;
            int sumRight = 0;
            int left;
            int right;
            int diff;
            for (int a = 0; a < n; a++)
            {
                left = int.Parse(Console.ReadLine());
                sumLeft = sumLeft + left;
            }
            for (int a = 0; a < n; a++)
            {
                right = int.Parse(Console.ReadLine());
                sumRight = sumRight + right;
            }
            diff = Math.Abs(sumLeft - sumRight);
            if (diff == 0)
            {
                Console.WriteLine("Yes, sum = {0}", sumLeft) ;
            }
            else
            {
                Console.WriteLine("No, diff = {0}", diff);
            }
        }
    }
}
