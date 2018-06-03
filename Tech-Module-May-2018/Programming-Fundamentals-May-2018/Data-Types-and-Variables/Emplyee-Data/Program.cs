using System;

namespace Emplyee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Age = int.Parse(Console.ReadLine()),
                Gender = char.Parse(Console.ReadLine()),
                ID = long.Parse(Console.ReadLine()),
                UniqueNumber = long.Parse(Console.ReadLine())
            };
            Console.WriteLine(
                $"First name: {emp.FirstName} \n" +
                $"Last name: {emp.LastName} \n" +
                $"Age: {emp.Age} \n" +
                $"Gender: {emp.Gender} \n" +
                $"Personal ID: {emp.ID} \n" +
                $"Unique Employee number: {emp.UniqueNumber}");
        }
    }
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public long ID { get; set; }
        public long UniqueNumber { get; set; }
    }
}
