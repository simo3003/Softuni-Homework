using System;

namespace Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(GetMax(a,b),c));
        }

        static int GetMax(int a, int b)
        {
            return (a > b) ? a : b;
        }
    }
}
