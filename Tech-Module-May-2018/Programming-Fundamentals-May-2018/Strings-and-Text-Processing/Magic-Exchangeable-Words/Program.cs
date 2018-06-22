using System;
using System.Collections.Generic;
using System.Linq;

namespace Magic_Exchangeable_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Console.WriteLine(AreWordsExchangeable(input).ToString().ToLower());
        }

        private static bool AreWordsExchangeable(string[] input) => input[0].Distinct().Count() == input[1].Distinct().Count();
    }
}
