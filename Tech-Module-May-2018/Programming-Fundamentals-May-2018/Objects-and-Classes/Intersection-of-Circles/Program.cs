using System;
using System.Linq;

namespace Intersection_of_Circles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Circle firstCircle = new Circle
            {
                Center = new Point
                {
                    X = firstInput[0],
                    Y = firstInput[1]
                },
                Radius = firstInput[2]
            };
            Circle secondCircle = new Circle
            {
                Center = new Point
                {
                    X = secondInput[0],
                    Y = secondInput[1]
                },
                Radius = secondInput[2]
            };
            Console.WriteLine(firstCircle.Intersect(secondCircle) ? "Yes" : "No");
        }
    }

    class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
        public bool Intersect(Circle circle2) 
        {
            double distanceBetweenCenters = Math.Sqrt(
                Math.Pow(Math.Abs(this.Center.X - circle2.Center.X), 2) +
                Math.Pow(Math.Abs(this.Center.Y - circle2.Center.Y), 2));
            return distanceBetweenCenters <= (this.Radius + circle2.Radius);
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
