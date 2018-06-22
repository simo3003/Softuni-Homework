using System;
using System.Text;

namespace Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            foreach (var character in input)
            {
                    sb.Append(@"\u");
                    sb.Append(String.Format($"{(int)character:x4}"));
            }
            Console.WriteLine(sb);
        }
    }
}
