using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateStr = Console.ReadLine();
            string format = "dd-MM-yyyy";
            DateTime date;
            date = DateTime.ParseExact(dateStr, format, CultureInfo.InvariantCulture);
            date = date.AddDays(999);
            dateStr = date.ToString(format);
            Console.WriteLine(dateStr);

        }
    }
}
