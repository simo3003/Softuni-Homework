using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string questionableThing = Console.ReadLine();
            if (questionableThing == "banana" || questionableThing == "apple" || questionableThing == "grapes" || questionableThing == "cherry" || questionableThing == "lemon" || questionableThing == "kiwi" )
            {
                Console.WriteLine("fruit");
            }
            else if (questionableThing == "tomato" || questionableThing == "cucumber" || questionableThing == "pepper" || questionableThing == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
