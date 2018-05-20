using System;

namespace Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            if (minutes+30>59)
            {
                minutes = (minutes + 30) - 60;
                hours++;
                if (hours>23)
                {
                    hours = hours - 24;
                }
                Console.WriteLine($"{hours}:{minutes:d2}");
            }
            else
            {
                minutes = minutes + 30;
                Console.WriteLine($"{hours}:{minutes:d2}");
            }
        }
    }
}
