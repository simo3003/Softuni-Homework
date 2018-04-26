using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Song
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int combinationTotal = 0;
            Boolean isKaruca = false;
            Boolean isPassword = false;
            int number = 0;
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int l = 1; l <= 9; l++)
                        {                     
                            if(i<j && k>l)
                            {                              
                                if (i*j + k*l == m)
                                {
                                    isKaruca = true;
                                    Console.Write($"{i}{j}{k}{l} ");
                                    combinationTotal++;
                                    if (combinationTotal == 4)
                                    {
                                        number = i * 1000 + j * 100 + k *10 +l;
                                        isPassword = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if(!isKaruca || !isPassword)
            {
                Console.WriteLine();
                Console.WriteLine("No!");
            }
            else if(isPassword == true)
            {
                Console.WriteLine();
                Console.WriteLine($"Password: {number}");
            }
        }
    }
}
