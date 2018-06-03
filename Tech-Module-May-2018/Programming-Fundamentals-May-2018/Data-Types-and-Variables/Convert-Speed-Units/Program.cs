using System;

namespace Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            float mPs = distance / (hours * 3600f + minutes * 60f + seconds);
            float kPh = (distance / 1000f) / (hours + minutes / 60f + seconds / 3600f);
            float mPh = (distance / 1609f) / (hours + minutes / 60f + seconds / 3600f);
            Console.WriteLine(mPs);
            Console.WriteLine(kPh);
            Console.WriteLine(mPh);
        }
    }
}
