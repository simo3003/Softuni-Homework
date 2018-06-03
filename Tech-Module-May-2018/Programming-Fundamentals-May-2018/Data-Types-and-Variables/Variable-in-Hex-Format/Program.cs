using System;

namespace Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine(), 16);
            Console.WriteLine(input);
        }
    }
}
