using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curreny_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var currency1 = double.Parse(Console.ReadLine());
            const double bgn = 1;
            const double usd = 1.79549;
            const double eur = 1.95583;
            const double gbp = 2.53405;        
            double trans;
            string from = Console.ReadLine();
            string to = Console.ReadLine();
                if (from == "USD")
            {
                if (to == "BGN")
                {
                    trans = currency1 * usd;
                    trans = Math.Round(trans, 2);
                    Console.WriteLine("{0} {1}",trans, to);
                }
                if (to == "EUR")
                {
                    trans = currency1 * usd;
                    trans = trans / eur;
                    trans = Math.Round(trans, 2);
                    Console.WriteLine("{0} {1}", trans, to);
                }
                if (to == "GBP")
                {
                    trans = currency1 * usd;
                    trans = trans / gbp;
                    trans = Math.Round(trans, 2);
                    Console.WriteLine("{0} {1}", trans, to);
                }
            }
            if (from == "BGN")
            {                               
                if (to == "EUR")
                {
                    trans = currency1 * bgn;
                    trans = trans / eur;
                    trans = Math.Round(trans, 2);
                    Console.WriteLine("{0} {1}", trans, to);
                }
                if (to == "GBP")
                {
                    trans = currency1 * bgn;
                    trans = trans / gbp;
                    trans = Math.Round(trans, 2);
                    Console.WriteLine("{0} {1}", trans, to);
                }
                if (to == "USD")
                {
                    trans = currency1 * bgn;
                    trans = trans / usd;
                    trans = Math.Round(trans, 2);
                    Console.WriteLine("{0} {1}", trans, to);
                }
            }
            if (from == "EUR")
            {
                if (to == "GBP")
                {
                    trans = currency1 * eur;
                    trans = trans / gbp;
                    trans = Math.Round(trans, 2);
                    Console.WriteLine("{0} {1}", trans, to);
                }
                if (to == "USD")
                {
                    trans = currency1 * eur;
                    trans = trans / usd;
                    trans = Math.Round(trans, 2);
                    Console.WriteLine("{0} {1}", trans, to);
                }
                if (to == "BGN")
                {
                    trans = currency1 * eur;
                    trans = Math.Round(trans, 2);
                    Console.WriteLine("{0} {1}", trans, to);
                }
            }
            if(from == "GBP")
            {
                if (to == "USD")
                {
                    trans = currency1 * gbp;
                    trans = trans / usd;
                    trans = Math.Round(trans, 2);
                    Console.WriteLine("{0} {1}", trans, to);
                }
                if (to == "BGN")
                {
                    trans = currency1 * gbp;
                    trans = Math.Round(trans, 2);
                    Console.WriteLine("{0} {1}", trans, to);
                }
                if (to == "EUR")
                {
                    trans = currency1 * gbp;
                    trans = trans / eur;
                    trans = Math.Round(trans, 2);
                    Console.WriteLine("{0} {1}", trans, to);
                }
            }
            
        }
    }
}
