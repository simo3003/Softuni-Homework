using System;
using System.Collections.Generic;

namespace Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            List<double> parameters = new List<double>();
            switch (type)
            {
                case "triangle":
                    parameters.Add(double.Parse(Console.ReadLine()));
                    parameters.Add(double.Parse(Console.ReadLine()));
                    Console.WriteLine($"{CalculateAreaOfTriangle(parameters[0], parameters[1]):f2}");
                    break;
                case "square":
                    parameters.Add(double.Parse(Console.ReadLine()));
                    Console.WriteLine($"{CalculateAreaOfSquare(parameters[0]):f2}");
                    break;
                case "rectangle":
                    parameters.Add(double.Parse(Console.ReadLine()));
                    parameters.Add(double.Parse(Console.ReadLine()));
                    Console.WriteLine($"{CalculateAreaOfRectangle(parameters[0], parameters[1]):f2}");
                    break;
                case "circle":
                    parameters.Add(double.Parse(Console.ReadLine()));
                    Console.WriteLine($"{CalculateAreaOfCircle(parameters[0]):f2}");
                    break;
           
            }
        }
        static double CalculateAreaOfSquare(double side) => side * side;// square
        static double CalculateAreaOfCircle(double radius) => Math.PI * radius * radius; // circle
        static double CalculateAreaOfTriangle(double side, double height) => side * height / 2; // triagnle
        static double CalculateAreaOfRectangle(double width, double height) => width * height; // rectangle

    }
}
