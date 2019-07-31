using System;
using System.Linq;

namespace Recursive_Array_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Console.WriteLine(Sum(nums, 0));
        }

        private static int Sum(int[] arr, int idx)
        {
            if (idx == arr.Length-1)
            {
                return arr[idx];
            }

            return Sum(arr, idx + 1) + arr[idx];
        }
    }
}
