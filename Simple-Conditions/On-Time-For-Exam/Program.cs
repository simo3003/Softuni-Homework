using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_Time_For_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var hourOfExam = int.Parse(Console.ReadLine());
            var minutesOfExam = int.Parse(Console.ReadLine());
            var hourOfArrival = int.Parse(Console.ReadLine());
            var minutesOfArrival = int.Parse(Console.ReadLine());
            int minutesWithZero;
            Boolean pass = false;
            if (hourOfArrival == hourOfExam) // hours match
            {
                if (minutesOfArrival == minutesOfExam) // minutes match 
                {
                    Console.WriteLine("On Time");
                }
                if (minutesOfArrival > minutesOfExam) // later than start
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0} minutes after the start", minutesOfArrival - minutesOfExam);
                }
            }
            if (hourOfArrival < hourOfExam)
            {
                minutesWithZero = minutesOfExam+60;
                if (hourOfExam - hourOfArrival >= 1)
                {
                    if (Math.Max(minutesOfArrival, minutesWithZero) - Math.Min(minutesWithZero, minutesOfArrival) <= 30)
                    {
                        pass = true;
                        Console.WriteLine("On Time");
                        Console.WriteLine("{0} minutes before the start", minutesWithZero - minutesOfArrival);
                    }
                    if (Math.Max(minutesOfArrival, minutesWithZero) - Math.Min(minutesWithZero, minutesOfArrival) < 10 && pass != true)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine("{0}:0{1} hours before the start", hourOfExam - hourOfArrival, Math.Max(minutesOfArrival, minutesOfExam) - Math.Min(minutesOfExam, minutesOfArrival));
                    }
                    else if (pass != true && minutesWithZero - minutesOfArrival >= 60)
                    {
                        Console.WriteLine("Early");           
                        Console.WriteLine("{0}:{1} hours before the start", hourOfExam - hourOfArrival, Math.Max(minutesOfArrival, minutesOfExam) - Math.Min(minutesOfExam, minutesOfArrival));
                    }
                    else
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine("{0} minutes before the start", Math.Max(minutesOfArrival, minutesWithZero) - Math.Min(minutesWithZero, minutesOfArrival));
                    }
                }

            }
            if (hourOfArrival > hourOfExam)
            {
                Console.WriteLine("Late");
                minutesWithZero = minutesOfArrival + 60;
                if (hourOfArrival - hourOfExam < 1 && minutesOfArrival == minutesOfExam)
                {
                    pass = true;
                    Console.WriteLine("{0} minutes after the start", Math.Max(minutesWithZero, minutesOfExam) - Math.Min(minutesOfExam, minutesWithZero));
                }
                    if (Math.Max(minutesWithZero, minutesOfExam) - Math.Min(minutesOfExam, minutesWithZero) < 10 && pass != true)
                    {
                        Console.WriteLine("{0}:0{1} after the start", hourOfArrival - hourOfExam, Math.Max(minutesWithZero, minutesOfExam) - Math.Min(minutesOfExam, minutesWithZero));
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1} after the start", hourOfArrival - hourOfExam, Math.Max(minutesWithZero, minutesOfExam) - Math.Min(minutesOfExam, minutesWithZero));
                    }

                }


        }
    }
}
