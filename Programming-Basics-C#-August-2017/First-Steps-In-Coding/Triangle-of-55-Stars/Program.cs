using System;

public class Program
{
    public static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            string stars = new string('*', i);
            Console.WriteLine(stars);
        }
    }
}