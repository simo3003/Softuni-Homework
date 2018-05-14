using System;

namespace Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            float w = float.Parse(Console.ReadLine());
            float h = float.Parse(Console.ReadLine());
            Console.WriteLine($"{(w*h):f2}");
        }
    }
}
