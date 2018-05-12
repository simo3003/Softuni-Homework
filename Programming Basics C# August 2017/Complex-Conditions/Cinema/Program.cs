using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            var rows = double.Parse(Console.ReadLine());
            var columns = double.Parse(Console.ReadLine());
            double price;
            if(type =="Premiere")
            {
                price = rows * columns * 12;
                Console.WriteLine("{0:f2}", price);
            }
            else if(type == "Normal")
            {
                price = rows * columns * 7.50;
                Console.WriteLine("{0:f2}", price);
            }
            else if(type == "Discount")
            {
                price = rows * columns * 5;
                Console.WriteLine("{0:f2}", price);
            }

        }
    }
}
