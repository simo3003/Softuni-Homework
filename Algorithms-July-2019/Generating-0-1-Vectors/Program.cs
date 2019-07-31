using System;

namespace Generating_0_1_Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var arr = new int[n];
            Gen01(arr, 0);
        }

        private static void Gen01(int[] vec, int idx)
        {
            if (idx >= vec.Length)
            {
                foreach(var num in vec)
                {
                    Console.Write(num);
                }

                Console.WriteLine();
                return;
            }

            vec[idx] = 0;
            Gen01(vec, idx + 1);

            vec[idx] = 1;
            Gen01(vec, idx + 1);
        }
    }
}
