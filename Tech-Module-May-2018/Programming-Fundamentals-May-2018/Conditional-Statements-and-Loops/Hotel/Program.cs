using System;
//D̤̩͎̘̯̺͙̭̰̖̻͚̞̗͙̬̤̫̆ͩ̎̉͂ͮͬ̐̿͑ͪ̌̽͠ ̈͆͊̄ͦͧͫ̈́̓̕͟͞͏̺̜̗͓̘̭̟̘͈̦̺̗̲̜͓̪Ẻ̸̡̦̠̮͖̼͌̔̅ͥ̾ͅ ̡̃̅̄̂͏̷̨̧̙̰̯̮͕̩͙̜̬̲̩ͅS̸̡̙̠͈̳̩̞͈̬̥͎̖̄ͦ͋̐ͯͫ͑̃ͭͪ͋̀̎́͢ͅ ̶̧̳̥͕͖͓͍̟͇̯͔̗̘̘̗̿̄ͩ̍͋̾̇̊̾͒̄ͭ̈͘͘P̶̴̛̦̙̖̪̼͚͙͗͑́͂ͮ͐̒ͣͭͮ͡͡ ̨̡̼̘̝̱͕͔̬̱͎̳̟͍̖ͬͭ̽̓̌̓͂̇̐͑ͥ̒̊ͣ̏ͅͅA̟̭̮̺̟̺͎͖̞̟̣̜͉͙̳͈̯ͤͫ̈̄̊̓̐̃̍ͮ͆́̚͢ͅ ̶̨̨̺͕̬͉̮͈̩̝͙͍̖͒͆͂̌ͬͪͬͫ͑̒͐͑̎͘C̲͉͇̙̦̖̙̞̝̘̫̟̣̼͕͇͔ͪ͊̇ͩ͑ͫ̑̒͋̊͊ͥ́̕͜͠ ͇̩̘̦̟͕̙͉̜̱͖͖̘̗̯͔͈͇ͦ͒ͮ̋̌͛͂̈́́ͤ͊̀ͤ̇̈̿̇̾̕͝I̷̢̨̫̭̠̤͕̦͓͉̫͙ͩ̇͂͗ͨ̐̒ͧ̈̓̒͆͢͟ ̸̛̃̀͛ͦ̆͑̎̊̒̆̃̓̈̋̿̓̆҉͇̺͉͝T̟͓̞̣̗̤̬̤̲̹̾̃̽̀̈́̄̒̀ͦͭ́̕͢͡͞O̢̖̖̖͍͈̗͚̠̰̻̳̣͈̗̭̦̤̪ͦ̊̓̔̈́̉͒ͫ̇̃͆̾͢͡͠
namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double doublePrice = 0;
            double suitePrice = 0;
            if (month == "May" || month == "October")
            {
                studioPrice = (nightsCount > 7) ? (nightsCount * (50 * 0.95)) : (nightsCount * 50);
                doublePrice = nightsCount * 65;
                suitePrice = nightsCount * 75;
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = nightsCount * 60;
                doublePrice = (nightsCount > 14) ? (nightsCount * (72 * 0.90)) : (nightsCount * 72);
                suitePrice = nightsCount * 82;
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = nightsCount * 68;
                doublePrice = nightsCount * 77;
                suitePrice = (nightsCount > 14) ? (nightsCount * (89 * 0.85)) : (nightsCount * 89);
            }
            if ((month == "September" || month == "October") && nightsCount > 7)
            {
                studioPrice -= (month == "September") ? 60 : (50 * 0.95);
            }
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
            Console.WriteLine($"Double: {doublePrice:f2} lv.");
            Console.WriteLine($"Suite: {suitePrice:f2} lv.");
        }
    }
}
