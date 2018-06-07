using System;
using System.Collections.Generic;
using System.Linq;

namespace Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            int[] searchArr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

        }
    }
}
