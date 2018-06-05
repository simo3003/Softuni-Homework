using System;

namespace Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToLower().ToCharArray();
            foreach (char character in input)
            {
                Console.WriteLine($"{character} -> {character - 97}");
            }
        }
    }
}
