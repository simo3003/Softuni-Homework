using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());
            var price = -1.0;
            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (fruit == "banana") price = quantity * 2.50;
                else if (fruit == "apple") price = quantity * 1.20;
                else if (fruit == "orange") price = quantity * 0.85;
                else if (fruit == "grapefruit") price = quantity * 1.45;
                else if (fruit == "kiwi") price = quantity * 2.70;
                else if (fruit == "pineapple") price = quantity * 5.50;
                else if (fruit == "grapes") price = quantity * 3.85;
            }
            if (day == "sunday" || day == "saturday")
            {
                if (fruit == "banana") price = quantity * 2.70;
                else if (fruit == "apple") price = quantity * 1.25;
                else if (fruit == "orange") price = quantity * 0.90;
                else if (fruit == "grapefruit") price = quantity * 1.60;
                else if (fruit == "kiwi") price = quantity * 3.00;
                else if (fruit == "pineapple") price = quantity * 5.60;
                else if (fruit == "grapes") price = quantity * 4.20;
            }
            if (price >= 0)
            {
                Console.WriteLine("{0:f2}", price);
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
