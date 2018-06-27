using System;
using System.Net;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalMoney = double.Parse(Console.ReadLine());
            int studentAmount = int.Parse(Console.ReadLine());
            double sabrePrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            int freeBelts = studentAmount / 6;
            double bill = sabrePrice * Math.Ceiling(studentAmount * 1.1) +
                          robePrice * (studentAmount) +
                          beltPrice * (studentAmount - freeBelts);
            Console.WriteLine(bill > totalMoney
                ? $"Ivan Cho will need {bill - totalMoney:f2}lv more."
                : $"The money is enough - it would cost {bill:f2}lv.");
        }
    }
}