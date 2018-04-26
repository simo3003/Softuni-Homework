using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = decimal.Parse(Console.ReadLine());
            string from = Console.ReadLine();
            string to = Console.ReadLine();
            const decimal mm = 1000;
            const decimal cm = 100;
            const decimal mi = 0.000621371192m;
            const decimal inches = 39.3700787m;
            const decimal km = 0.001m;
            const decimal ft = 3.2808399m;
            const decimal yd = 1.0936133m;
            decimal trans;
            if (from == "mm")
            {
                trans = num / mm;
                if (to == "m")
                {
                    Console.WriteLine(trans);
                }
                if (to == "mm")
                {
                    trans = trans * mm;
                    trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "cm")
                {
                    trans = trans * cm;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "mi")
                {
                    trans = trans * mi;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "in")
                {
                    trans = trans * inches;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "km")
                {
                    trans = trans * km;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "ft")
                {
                    trans = trans * ft;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "yd")
                {
                    trans = trans * yd;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }

            }
            if (from == "cm")
            {
                trans = num / cm;
                if (to == "m")
                {
                    Console.WriteLine(trans);
                }
                if (to == "cm")
                {
                    trans = trans * cm;
                    trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "mm")
                {
                    trans = trans * mm;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "mi")
                {
                    trans = trans * mi;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "in")
                {
                    trans = trans * inches;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "km")
                {
                    trans = trans * km;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "ft")
                {
                    trans = trans * ft;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "yd")
                {
                    trans = trans * yd;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
            }
            if (from == "mi")
            {
                trans = num / mi;
                if (to == "m")
                {
                    Console.WriteLine(trans);
                }
                if (to == "mi")
                {
                    trans = trans * mi;
                    trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "mm")
                {
                    trans = trans * mm;
                    trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "cm")
                {
                    trans = trans * cm;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "in")
                {
                    trans = trans * inches;
                    trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "km")
                {
                    trans = trans * km;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "ft")
                {
                    trans = trans * ft;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "yd")
                {
                    trans = trans * yd;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
            }
            if (from == "in")
            {
                trans = num / inches;
                if (to == "m")
                {
                    Console.WriteLine(trans);
                }
                if (to == "in")
                {
                    trans = trans * inches;
                    trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "mm")
                {
                    trans = trans * mm;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "mi")
                {
                    trans = trans * mi;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "cm")
                {
                    trans = trans * cm;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "km")
                {
                    trans = trans * km;
                    trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "ft")
                {
                    trans = trans * ft;
                    trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "yd")
                {
                    trans = trans * yd;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
            }
            if (from == "km")
            {
                trans = num / km;
                if (to == "m")
                {
                    Console.WriteLine(trans);
                }
                if (to == "km")
                {
                    trans = trans * km;
                    trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "mm")
                {
                    trans = trans * mm;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "mi")
                {
                    trans = trans * mi;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "in")
                {
                    trans = trans * inches;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "cm")
                {
                    trans = trans * cm;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "ft")
                {
                    trans = trans * ft;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "yd")
                {
                    trans = trans * yd;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
            }
            if (from == "ft")
            {
                trans = num / ft;
                if (to == "m")
                {
                    Console.WriteLine(trans);
                }
                if (to == "ft")
                {
                    trans = trans * ft;
                    trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "mm")
                {
                    trans = trans * mm;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "mi")
                {
                    trans = trans * mi;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "in")
                {
                    trans = trans * inches;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "km")
                {
                    trans = trans * km;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "cm")
                {
                    trans = trans * cm;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "yd")
                {
                    trans = trans * yd;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
            }
            if (from == "yd")
            {
                trans = num / yd;
                if (to == "m")
                {
                    Console.WriteLine(trans);
                }
                if (to == "yd")
                {
                    trans = trans * yd;
                    trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "mm")
                {
                    trans = trans * mm;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "mi")
                {
                    trans = trans * mi;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "in")
                {
                    trans = trans * inches;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "km")
                {
                    trans = trans * km;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "ft")
                {
                    trans = trans * ft;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "cm")
                {
                    trans = trans * cm;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
            }
            if (from == "m")
            {
                trans = num;
                if (to == "m")
                {
                    Console.WriteLine(trans);
                }
                if (to == "cm")
                {
                    trans = trans * cm;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "mm")
                {
                    trans = trans * mm;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "mi")
                {
                    trans = trans * mi;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "in")
                {
                    trans = trans * inches;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "km")
                {
                    trans = trans * km;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "ft")
                {
                    trans = trans * ft;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
                if (to == "yd")
                {
                    trans = trans * yd;
                     trans = Math.Round(trans, 8);
                    Console.WriteLine(trans);
                }
            }
        }
        }
}
