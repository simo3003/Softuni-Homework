using System;

namespace Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            if (day == "weekday")
            {
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                {
                    Console.WriteLine("12$");
                    return;
                }
                else if (age > 18 && age <= 64)
                {
                    Console.WriteLine("18$");
                    return;
                }
                else
                {
                    Console.WriteLine("Error!");
                    return;
                }
            }
            else if (day == "weekend")
            {
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                {
                    Console.WriteLine("15$");
                    return;
                }
                else if (age > 18 && age <= 64)
                {
                    Console.WriteLine("20$");
                    return;
                }
                else
                {
                    Console.WriteLine("Error!");
                    return;
                }
            }
            else if (day == "holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    Console.WriteLine("5$");
                    return;
                }
                else if (age > 64 && age <= 122)
                {
                    Console.WriteLine("10$");
                    return;
                }
                else if (age > 18 && age <= 64)
                {
                    Console.WriteLine("12$");
                    return;
                }
                else
                {
                    Console.WriteLine("Error!");
                    return;
                }
            }
        }
    }
}
