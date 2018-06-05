using System;
using System.Linq;

namespace Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] first = Console.ReadLine().ToCharArray().Where(x=>x!=' ').ToArray();
            char[] second = Console.ReadLine().ToCharArray().Where(x => x != ' ').ToArray(); ;
            int minLength = Math.Min(first.Length, second.Length);
            if (new string(first) == new string(second))
            {
                Console.WriteLine(new string(first));
                Console.WriteLine(new string(second));
                return;
            }
            else
            {
                bool isPartiallyEqual = false;
                for (int i = 0; i < minLength; i++)
                {
                    if (first[i] == second[i])
                    {
                        isPartiallyEqual = true;
                        continue;
                    }
                    isPartiallyEqual = false;
                }

                if (isPartiallyEqual)
                {
                    if (first.Length < second.Length)
                    {
                        Console.WriteLine(new string(first));
                        Console.WriteLine(new string(second));
                        return;
                    }
                    else if (second.Length < first.Length)
                    {
                        Console.WriteLine(new string(second));
                        Console.WriteLine(new string(first));
                        return;
                    }
                }
                else
                {
                    for (int i = 0; i < minLength; i++)
                    {
                        if (first[i] == second[i])
                        {
                            continue;
                        }

                        if (first[i] < second[i])
                        {
                            Console.WriteLine(new string(first));
                            Console.WriteLine(new string(second));
                            return;
                        }
                        else
                        {
                            Console.WriteLine(new string(second));
                            Console.WriteLine(new string(first));
                            return;
                        }
                    }
                }
            }

        }
    }
}
