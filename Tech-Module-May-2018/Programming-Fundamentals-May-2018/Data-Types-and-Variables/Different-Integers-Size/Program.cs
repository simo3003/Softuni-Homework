using System;

namespace Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNum = Console.ReadLine();
            if (long.TryParse(inputNum, out long number))
            {
                Console.WriteLine($"{number} can fit in:");
                if (sbyte.TryParse(inputNum, out sbyte sbyteNum))
                {
                    Console.WriteLine("* sbyte");
                }

                if (byte.TryParse(inputNum, out byte byteNum))
                {
                    Console.WriteLine("* byte");
                }

                if (short.TryParse(inputNum, out short shortNum))
                {
                    Console.WriteLine("* short");
                }

                if (ushort.TryParse(inputNum, out ushort ushortNum))
                {
                    Console.WriteLine("* ushort");
                }

                if (int.TryParse(inputNum, out int intNum))
                {
                    Console.WriteLine("* int");
                }

                if (uint.TryParse(inputNum, out uint uintNum))
                {
                    Console.WriteLine("* uint");
                }

                Console.WriteLine("* long");
            }
            else
            {
                Console.WriteLine($"{inputNum} can't fit in any type");
            }
        }
    }
}
