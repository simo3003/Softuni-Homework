using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXAMPLES
            // ds3bhj y1ter/wfsdg 1nh_jgf ds2c_vbg\4htref       <- input
            // ds3bhj y1ter wfsdg  ds2c_vbg                     <- valid usernames
            // 6      5     5      7                            <- length of usernames
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // min23/ace hahah21 (    sasa  )  att3454/a/a2/abc <- input
            // min23 hahah21 sasa att3454                       <- valid usernames
            // 5     7       4    7                             <- length of usernames
            string[] input = Console.ReadLine().Split(new[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> validUserNames = input
                .Where(user => Regex.Match(user, @"([A-Za-z0-9_]+)").Success // verifies the usernames 
                               && user.Length >= 3 && user.Length <= 25 // checks the length
                               && char.IsLetter(user[0])) // checks if it starts with a letter
                               .ToList();

            int bestIndex = 1;
            int bestSum = 0;
            for (int i = 1; i < validUserNames.Count; i++)
            {
                int sum = validUserNames[i].Length + validUserNames[i - 1].Length;
                int index = i;
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestIndex = index;
                }
            }

            Console.WriteLine(validUserNames[bestIndex - 1]);
            Console.WriteLine(validUserNames[bestIndex]);
        }
    }
}
