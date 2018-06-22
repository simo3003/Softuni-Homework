using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sum_Big_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNum = Console.ReadLine().TrimStart('0'); ;
            string secondNum = Console.ReadLine().TrimStart('0'); ;
            Console.WriteLine(Sum(firstNum, secondNum));
        }

        private static string Sum(string firstNum, string secondNum)
        {
            StringBuilder sb = new StringBuilder();
            int remainder = 0;
            if (firstNum.Length > secondNum.Length) // adds zeroes to the beginning of the smaller number
            {
                secondNum = secondNum.PadLeft(firstNum.Length, '0');
            }
            else
            {
                firstNum = firstNum.PadLeft(secondNum.Length, '0');
            }

            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                int currentSum = int.Parse(firstNum[i].ToString()) + int.Parse(secondNum[i].ToString()) + remainder;
                remainder = 0;
                if (currentSum < 10)
                {
                    sb.Append(currentSum);
       
                }
                else
                {
                    remainder = currentSum / 10; // 12 -> 1
                    sb.Append(currentSum % 10);
                }
            }

            if (remainder != 0)
            {
                sb.Append(remainder);
            }

            return string.Join(string.Empty, sb.ToString().Reverse());
        }
    }
}
