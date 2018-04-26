using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());
            double comission = -1;
            if (city == "sofia")
            {
                if (quantity <= 500 && quantity >= 0) comission = 0.05;
                else if (quantity > 500 && quantity <= 1000) comission = 0.07;
                else if (quantity > 1000 && quantity <= 10000) comission = 0.08;
                else if (quantity > 10000) comission = 0.12;
            }
            if (city == "varna")
            {
                if (quantity <= 500 && quantity >= 0) comission = 0.045;
                else if (quantity > 500 && quantity <= 1000) comission = 0.075;
                else if (quantity > 1000 && quantity <= 10000) comission = 0.1;
                else if (quantity > 10000) comission = 0.13;
            }
            if (city == "plovdiv")
            {
                if (quantity <= 500 && quantity >= 0) comission = 0.055;
                else if (quantity > 500 && quantity <= 1000) comission = 0.08;
                else if (quantity > 1000 && quantity <= 10000) comission = 0.12;
                else if (quantity > 10000) comission = 0.145;
            }
            if(comission == -1)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("{0:f2}", comission*quantity);
            }
        }
    }
}
