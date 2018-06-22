using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNum = Console.ReadLine().TrimStart('0');
            string secondNum = Console.ReadLine();
            Console.WriteLine(BigInteger.Parse(firstNum) * BigInteger.Parse(secondNum)); // fuck this shit
        }
    }
}
