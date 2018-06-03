using System;

namespace Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(
                $"Before: \n" +
                $"a = {a} \n" +
                $"b = {b} \n" +
                $"After: \n" +
                $"a = {b} \n" +
                $"b = {a} ");
        }
    }
}
