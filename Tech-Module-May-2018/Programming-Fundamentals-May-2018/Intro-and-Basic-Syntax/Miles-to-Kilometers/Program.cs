using System;

namespace Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            float miles = float.Parse(Console.ReadLine());
            Console.WriteLine($"{(miles* 1.60934 ):f2}");
        }
    }
}
