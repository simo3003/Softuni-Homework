using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string keys = Console.ReadLine();
            string text = Console.ReadLine();
            string startKey = Regex.Match(keys, @"^(?<start>[A-Za-z]+)(<|\||\\)").Groups["start"].ToString();
            string endKey = Regex.Match(keys, @"(<|\||\\)(?<end>[A-Za-z]+)$").Groups["end"].ToString();
            string extractPattern = $@"({startKey})(?<message>.*?)({endKey})";
            var result = new StringBuilder();
            foreach (Match match in Regex.Matches(text, extractPattern))
            {
                result.Append(match.Groups["message"]);
            }
            Console.WriteLine(result.Length != 0 ? string.Join(string.Empty, result) : "Empty result");
        }
    }
}
