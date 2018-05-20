using System;

namespace Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hall = "";
            double price = 0;
            if (groupSize <= 50)
            {
                hall = "Small Hall";
                price += 2500;
            }
            else if (groupSize <= 100)
            {
                hall = "Terrace";
                price += 5000;
            }
            else if (groupSize <= 120)
            {
                hall = "Great Hall";
                price += 7500;
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }
            switch (package)
            {
                case "Normal":
                    price += 500;
                    price = price - (0.05 * price);
                    break;
                case "Gold":
                    price += 750;
                    price = price - (0.10 * price);
                    break;
                case "Platinum":
                    price += 1000;
                    price = price - (0.15 * price);
                    break;
            }
            Console.WriteLine($"We can offer you the {hall} \nThe price per person is {(price/groupSize):f2}$");
        }
    }
}
