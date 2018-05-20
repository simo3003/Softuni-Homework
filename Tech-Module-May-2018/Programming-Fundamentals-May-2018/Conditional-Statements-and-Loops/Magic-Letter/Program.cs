using System;

namespace Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            string skip = Console.ReadLine();
            string temp = "";
            for (char i = a; i <= b; i++)
            {
                for (char j = a; j <= b; j++)
                {
                    for (char k = a; k <= b; k++)
                    {
                        temp = $"{i}{j}{k} ";
                        if (temp.Contains(skip))
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write(temp);
                        }
                    }
                }
            }
        }
    }
}
