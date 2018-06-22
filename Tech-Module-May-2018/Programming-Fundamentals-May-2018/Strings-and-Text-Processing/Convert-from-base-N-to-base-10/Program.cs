using System;
using System.Numerics;
using System.Text;

namespace Convert_from_base_N_to_base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int sourceBase = int.Parse(input[0]);
            BigInteger num = BigInteger.Parse(input[1]);
            Console.WriteLine(ConvertoToBase10FromN(num, sourceBase));
        }

        static string ConvertoToBase10FromN(BigInteger num, int sourceBase)
        {
            BigInteger result = 0;
            int power = 0;
            while (num > 0)
            {
                int mostRightDigit = (int)(num % 10);
                var currentNum = mostRightDigit * BigInteger.Pow(sourceBase, power);
                num /= 10;
                power++;
                result += currentNum;
            }
            return result.ToString();
        }
    }
}
