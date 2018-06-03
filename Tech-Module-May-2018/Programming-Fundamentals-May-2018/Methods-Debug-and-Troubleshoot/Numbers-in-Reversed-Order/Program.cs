using System;

namespace Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(ReverseNumbers(input));
        }

        static string ReverseNumbers(string input)
        {
            var output = input.ToCharArray();
            Array.Reverse(output);
            return new string(output);
        }
    }
}
