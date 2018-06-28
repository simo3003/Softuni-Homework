using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballAmount = int.Parse(Console.ReadLine());
            BigInteger maxValue = 0;
            int maxSnow = 0, maxTime = 0, maxQuality = 0;
            for (int i = 0; i < snowballAmount; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());
                BigInteger value = BigInteger.Pow(snow / time, quality);
                if (value>maxValue)
                {
                    maxValue = value;
                    maxSnow = snow;
                    maxTime = time;
                    maxQuality = quality;
                }
            }
            Console.WriteLine($"{maxSnow} : {maxTime} = {maxValue} ({maxQuality})");
        }
    }
}
