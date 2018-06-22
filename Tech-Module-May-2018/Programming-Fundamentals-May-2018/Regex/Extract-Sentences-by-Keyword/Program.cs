using System;
using System.Text.RegularExpressions;
using System.Linq;
namespace Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b" + input + @"\b";
            string[] text = Console.ReadLine().Split(new[] {'.','!','?'}, StringSplitOptions.RemoveEmptyEntries).Select(x=>x.Trim()).ToArray();
            foreach (var sentence in text)
            {
                if (Regex.IsMatch(sentence, pattern))
                {
                    Console.WriteLine(sentence);
                }
            }
        }
    }
}
