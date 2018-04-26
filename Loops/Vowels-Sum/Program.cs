using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char single = s[i];
                if (single == 'a')
                {
                    sum = sum + 1;
                }
                else  if (single == 'e')
                {
                    sum = sum + 2;
                }
                else if (single == 'i')
                {
                    sum = sum + 3;
                }
                else if (single == 'o')
                {
                    sum = sum + 4;
                }
                else if (single == 'u')
                {
                    sum = sum + 5;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
