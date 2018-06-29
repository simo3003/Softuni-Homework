using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            string encodedText = Console.ReadLine();
            var placeholders = Regex.Matches(encodedText, @"([A-Za-z]+)(?<placeholder>.+)(\1)");
            var values = Console.ReadLine().Split(new char[] {'{','}'}, StringSplitOptions.RemoveEmptyEntries).ToList();
            for (int i = 0; i < placeholders.Count; i++)
            {
                Match textMatch = placeholders[i];
                string placeholder = textMatch.Groups["placeholder"].Value;
                string temp = textMatch.ToString().Replace(placeholder, values[0]);
                encodedText = encodedText.Replace(textMatch.ToString(), temp);
                values.RemoveAt(0);
            }
            Console.WriteLine(encodedText);
        }
    }
}
