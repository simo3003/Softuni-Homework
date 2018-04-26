using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    if(n%2==0)
                    {
                        Console.WriteLine(n);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Greshka Pich");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Greshka Pich");
                }
            } while (true);

        }
    }
}
