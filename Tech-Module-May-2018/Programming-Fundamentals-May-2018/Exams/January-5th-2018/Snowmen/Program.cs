using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> snowmen = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (snowmen.Count > 1)
            {
                for (int i = 0; i < snowmen.Count; i++)
                {
                    int attacker = i;
                    int target = snowmen[i] % snowmen.Count;
                    if (snowmen.Count(x => x != -1) == 1)
                    {
                        break;
                    }
                    if (snowmen[attacker] == -1) // if the current snowman is dead
                    {
                        continue;
                    }
                    int diff = Math.Abs(attacker - target);
                    if (attacker == target) // if they match
                    {
                        Console.WriteLine($"{attacker} performed harakiri");
                        snowmen[attacker] = -1; // add either the attacker or the target, as they match -> attacker = 1; target = 1 -> same snowman
                        continue;
                    }
                    if (diff % 2 == 0) // if it's even
                    {
                        Console.WriteLine($"{attacker} x {target} -> {attacker} wins");
                        snowmen[target] = -1;
                        continue;
                    }
                    if (diff % 2 != 0) // if it's odd
                    {
                        Console.WriteLine($"{attacker} x {target} -> {target} wins");
                        snowmen[attacker] = -1;
                    }
                }
                snowmen = snowmen.Where(x => x != -1).ToList();
            }
        }
    }
}
