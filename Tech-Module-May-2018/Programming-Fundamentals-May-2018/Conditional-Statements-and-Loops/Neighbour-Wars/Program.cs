using System;

namespace Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDmg = int.Parse(Console.ReadLine());
            int goshoDmg = int.Parse(Console.ReadLine());
            int peshoHp = 100;
            int goshoHp = 100;
            int rounds = 1;
            while (true)
            {
                if (rounds % 2 == 0)
                {
                    peshoHp -= goshoDmg;
                    if (peshoHp > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHp} health.");
                    }
                }
                else 
                {
                    goshoHp -= peshoDmg;
                    if (goshoHp > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHp} health.");
                    }
                }
                if (peshoHp <= 0)
                {
                    Console.WriteLine($"Gosho won in {rounds}th round.");
                    break;
                }
                else if (goshoHp <= 0)
                {
                    Console.WriteLine($"Pesho won in {rounds}th round.");
                    break;
                }
                if (rounds % 3 == 0)
                {
                    peshoHp += 10;
                    goshoHp += 10;
                }
                rounds++;
            }
        }
    }
}
