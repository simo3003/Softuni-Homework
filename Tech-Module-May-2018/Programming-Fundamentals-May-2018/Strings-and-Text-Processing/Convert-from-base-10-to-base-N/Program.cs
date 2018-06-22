using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int targetBase = int.Parse(input[0]);
            BigInteger num = BigInteger.Parse(input[1]);
            Console.WriteLine(ConvertoToBaseNFrom10(num, targetBase));
        }

        static string ConvertoToBaseNFrom10(BigInteger num, int targetBase)
        {
            StringBuilder sb = new StringBuilder();
            while (num > 0) 
            {
                int remainder = (int)(num % targetBase);
                sb.Append(remainder);
                num /= targetBase;
            } 
            return string.Join(string.Empty, sb.ToString().ToCharArray().Reverse());
        }
    }
}
