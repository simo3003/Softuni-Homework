using System;
using System.Linq;
namespace Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();
            DateTime startDate = DateTime.ParseExact(firstInput, "dd-MM-yyyy", null);
            DateTime endDate = DateTime.ParseExact(secondInput, "dd-MM-yyyy", null);
            DateTime[] holidays = {
                new DateTime(2016, 01, 01),
                new DateTime(2016, 03, 03),
                new DateTime(2016, 05, 01),
                new DateTime(2016, 05, 06),
                new DateTime(2016, 05, 24),
                new DateTime(2016, 09, 06),
                new DateTime(2016, 09, 22),
                new DateTime(2016, 11, 01),
                new DateTime(2016, 12, 24),
                new DateTime(2016, 12, 25),
                new DateTime(2016, 12, 26)
            };
            int workingDays = 0;
            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                DateTime currentDay = new DateTime(2016, i.Month, i.Day);
                if (!holidays.Contains(currentDay) && i.DayOfWeek != DayOfWeek.Saturday &&
                    i.DayOfWeek != DayOfWeek.Sunday)
                {
                    workingDays++;
                }
            }

            Console.WriteLine(workingDays);
        }
    }
}
