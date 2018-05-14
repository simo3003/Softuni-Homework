using System;

namespace Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int id = int.Parse(Console.ReadLine());
            float salary = float.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {id:d8}");
            Console.WriteLine($"Salary: {salary:f2}");
        }
    }
}
