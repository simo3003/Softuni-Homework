using System;

namespace Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = (Convert.ToBoolean(input)) ? "Yes" : "No";
            Console.WriteLine(output);
        }
    }
}
