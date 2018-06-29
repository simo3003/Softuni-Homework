using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keebPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());
            float rageExpenses = 0;
            bool hasTrashedKeebOnce = false;
            for (int currentGame = 1; currentGame <= lostGames; currentGame++)
            {
                if (currentGame % 2 == 0 && currentGame % 3 == 0 && !hasTrashedKeebOnce)
                {
                    rageExpenses += headsetPrice;
                    rageExpenses += mousePrice;
                    rageExpenses += keebPrice;
                    hasTrashedKeebOnce = true;
                }
                else if (currentGame % 2 == 0 && currentGame % 3 == 0 && hasTrashedKeebOnce)
                {
                    rageExpenses += headsetPrice;
                    rageExpenses += mousePrice;
                    rageExpenses += keebPrice;
                    rageExpenses += displayPrice;
                    hasTrashedKeebOnce = false;
                }
                else if (currentGame % 2 == 0)
                {
                    rageExpenses += headsetPrice;
                }
                else if (currentGame % 3 == 0)
                {
                    rageExpenses += mousePrice;
                }
            }
            Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");
        }
    }
}
