using System;
using System.Text.RegularExpressions;

namespace Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(?<=\s)[A-Za-z0-9]+([\.\-_][A-za-z0-9]+)*@[A-Za-z]+(\-[A-Za-z]+)*(\.[A-za-z]+)+";
            foreach (Match match in Regex.Matches(text, pattern))
            {
                Console.WriteLine(match.Value);
            } 
        }
    }
}
