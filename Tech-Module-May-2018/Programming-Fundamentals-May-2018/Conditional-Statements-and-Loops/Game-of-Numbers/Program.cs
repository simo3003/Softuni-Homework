using System;

namespace Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int combinations = 0;
            string lastMagicCombo = "";
            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    combinations++;
                    if (i + j == magicNum)
                    {
                        lastMagicCombo = $"{i} + {j} = {magicNum}";
                    }
                }
            }
            if (lastMagicCombo == "")
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNum}");
            }
            else
            {
                Console.WriteLine($"Number found! {lastMagicCombo}");
            }
        }
    }
}
