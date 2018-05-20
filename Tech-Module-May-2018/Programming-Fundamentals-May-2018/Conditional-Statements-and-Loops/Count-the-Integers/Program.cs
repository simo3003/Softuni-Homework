using System;

namespace Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int counter = 0;
            while (int.TryParse(input, out int ignoreTempVariable))
            {
                counter++;
                input = Console.ReadLine();
            }
            Console.WriteLine(counter);
        }
    }
}
