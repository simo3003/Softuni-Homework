using System;
using System.Numerics;

namespace SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            // PER HOUR
            BigInteger studentsForA = BigInteger.Parse(Console.ReadLine());
            BigInteger studentsForB = BigInteger.Parse(Console.ReadLine());
            BigInteger studentsForC = BigInteger.Parse(Console.ReadLine());
            BigInteger students = BigInteger.Parse(Console.ReadLine());
            BigInteger normForAll = studentsForA + studentsForB + studentsForC;
            BigInteger i = 0;
            BigInteger totalHours = 0;

            if (normForAll == 0)
            {
                Console.WriteLine($"Time needed: {totalHours}h.");
                return;
            }

            if (normForAll >= students)
            {
                totalHours = 1;
            }

            else
            {
                while (students > 0)
                {
                    students -= normForAll;
                    i++;
                    if (i % 4 == 0 && i != 0)
                    {
                        students += normForAll;
                    }
                    if (students <= 0)
                    {
                        break;
                    }
                }
                totalHours = i;
            }
            Console.WriteLine($"Time needed: {totalHours}h.");
        }
    }
}
