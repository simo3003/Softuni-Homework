using System;

namespace Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (char i = (char)a; i <= (char)b; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
