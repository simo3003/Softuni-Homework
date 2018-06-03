using System;

namespace Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long picsTaken = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            long picsFiltered = (long)Math.Ceiling(picsTaken * (filterFactor / 100.0));
            long filterTimeSpent = filterTime * picsTaken;
            long uploadTimeSpent = picsFiltered * uploadTime;
            long timeSpent = filterTimeSpent + uploadTimeSpent;

            TimeSpan t = TimeSpan.FromSeconds(timeSpent);
            Console.WriteLine($"{t.Days:d1}:{t.Hours:d2}:{t.Minutes:d2}:{t.Seconds:d2}");
        }
    }
}
