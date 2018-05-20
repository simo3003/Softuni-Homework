using System;
//D̤̩͎̘̯̺͙̭̰̖̻͚̞̗͙̬̤̫̆ͩ̎̉͂ͮͬ̐̿͑ͪ̌̽͠ ̈͆͊̄ͦͧͫ̈́̓̕͟͞͏̺̜̗͓̘̭̟̘͈̦̺̗̲̜͓̪Ẻ̸̡̦̠̮͖̼͌̔̅ͥ̾ͅ ̡̃̅̄̂͏̷̨̧̙̰̯̮͕̩͙̜̬̲̩ͅS̸̡̙̠͈̳̩̞͈̬̥͎̖̄ͦ͋̐ͯͫ͑̃ͭͪ͋̀̎́͢ͅ ̶̧̳̥͕͖͓͍̟͇̯͔̗̘̘̗̿̄ͩ̍͋̾̇̊̾͒̄ͭ̈͘͘P̶̴̛̦̙̖̪̼͚͙͗͑́͂ͮ͐̒ͣͭͮ͡͡ ̨̡̼̘̝̱͕͔̬̱͎̳̟͍̖ͬͭ̽̓̌̓͂̇̐͑ͥ̒̊ͣ̏ͅͅA̟̭̮̺̟̺͎͖̞̟̣̜͉͙̳͈̯ͤͫ̈̄̊̓̐̃̍ͮ͆́̚͢ͅ ̶̨̨̺͕̬͉̮͈̩̝͙͍̖͒͆͂̌ͬͪͬͫ͑̒͐͑̎͘C̲͉͇̙̦̖̙̞̝̘̫̟̣̼͕͇͔ͪ͊̇ͩ͑ͫ̑̒͋̊͊ͥ́̕͜͠ ͇̩̘̦̟͕̙͉̜̱͖͖̘̗̯͔͈͇ͦ͒ͮ̋̌͛͂̈́́ͤ͊̀ͤ̇̈̿̇̾̕͝I̷̢̨̫̭̠̤͕̦͓͉̫͙ͩ̇͂͗ͨ̐̒ͧ̈̓̒͆͢͟ ̸̛̃̀͛ͦ̆͑̎̊̒̆̃̓̈̋̿̓̆҉͇̺͉͝T̟͓̞̣̗̤̬̤̲̹̾̃̽̀̈́̄̒̀ͦͭ́̕͢͡͞O̢̖̖̖͍͈̗͚̠̰̻̳̣͈̗̭̦̤̪ͦ̊̓̔̈́̉͒ͫ̇̃͆̾͢͡͠
namespace Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string noun = Console.ReadLine();
            if (noun.EndsWith("y"))
            {
                noun = noun.Remove(noun.Length-1);
                noun += "ies";
            }
            else if (noun.EndsWith("o") || noun.EndsWith("ch") || noun.EndsWith("s") || noun.EndsWith("sh") || noun.EndsWith("x") || noun.EndsWith("z"))
            {
                noun += "es";
            }
            else
            {
                noun += "s";
            }
            Console.WriteLine(noun);
        }
    }
}
