using System;

namespace Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(a, 16).ToUpper());
            Console.WriteLine(Convert.ToString(a, 2).ToUpper());
        }
    }
}
