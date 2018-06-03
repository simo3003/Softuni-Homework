using System;

namespace Strings_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            object c = a + " " + b;
            string d = (string)c;
            Console.WriteLine(d);
        }
    }
}
