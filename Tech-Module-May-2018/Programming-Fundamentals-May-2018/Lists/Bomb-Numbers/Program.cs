using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> settings = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int specialBomb = settings[0];
            int specialBombPower = settings[1];
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == specialBomb)
                {
                    if (i + specialBombPower > input.Count)
                    {
                        input.RemoveRange(i - specialBombPower, specialBombPower + 1 + (input.Count - 1 - i));

                    }
                    else if (i - specialBombPower < 0)
                    {
                        input.RemoveRange(0, i + 1 + specialBombPower);
                    }
                    else
                    {
                        input.RemoveRange(i - specialBombPower, specialBombPower + 1 + specialBombPower);
                    }
                }
				i = 0;
            }
            Console.WriteLine(input.Sum());
        }
    }
}
