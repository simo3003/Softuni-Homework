using System;

public class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        string stars = new string('*', n);
        string space = new string(' ', n - 2);
        for (int i = 1; i <= n; i++)
        {
            if (i == 1 || i == n)
            {
                Console.WriteLine(stars);
            }
            else
            {
                Console.Write("*");
                Console.Write(space);
                Console.WriteLine("*");
            }
        }
    }
}