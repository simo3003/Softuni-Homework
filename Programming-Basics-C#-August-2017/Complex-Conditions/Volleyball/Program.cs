using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            var p = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            double weekendsInSofia = 48 - h;
            double weekendGamesInSofia = (3.0 / 4 * weekendsInSofia);
            double weekendGamesInH = h;
            double gamesDuringVac = (2.0 / 3 * p);
            double sum = weekendGamesInSofia + weekendGamesInH + gamesDuringVac;
            if (yearType == "leap") sum += sum * 0.15;
            sum = Math.Truncate(sum);
            Console.WriteLine(sum);
        }
    }
}
