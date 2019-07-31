using System;
using System.Linq;

namespace Generating_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            Gen(nums, new int[n], 0, 0);
        }

        private static void Gen(int[] set, int[] vec, int idx, int border)
        {
            if (idx == vec.Length)
            {
                Console.WriteLine(string.Join(" ", vec));
                return;
            }

            for (int i = border; i < set.Length; i++)
            {
                vec[idx] = set[i];
                Gen(set, vec, idx + 1, i + 1);
            }
        }
    }
}
