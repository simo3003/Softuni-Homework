using System;
using System.Linq;

namespace Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNum = int.Parse(Console.ReadLine());
            PrintMasterNumbersInRange(maxNum);
            Console.ReadLine(); 
        }
        static void PrintMasterNumbersInRange(int maxNum)
        {
            for (int i = 232; i <= maxNum; i++) // 232 is the minimum Master Number, so we exlucde the numbers up to 232
            {

                if (SumOfDigitsDivBy7(i) && ContainsEvenDigit(i) && IsPalindrome(i))
                { 
                    Console.WriteLine(i);
                }
            }
        }
        static bool IsPalindrome(int num)
        {
            string numString = num.ToString();
            if (numString.Length % 2 == 0)
            {
                string firstPart = numString.Substring(0, numString.Length / 2);
                string secondPart = numString.Substring(numString.Length / 2, (numString.Length / 2));
                secondPart = ReverseString(secondPart);
                return firstPart == secondPart;
            }
            else
            {
                string firstPart = numString.Substring(0, (numString.Length - 1) / 2);
                string secondPart = numString.Substring((numString.Length + 1) / 2, ((numString.Length - 1) / 2));
                secondPart = ReverseString(secondPart);
                return firstPart == secondPart;
            }

        }
        static bool SumOfDigitsDivBy7(int num)
        {
            int sumDigits = 0;

            while (num > 0)
            {
                int lastDigit = num % 10;
                sumDigits += lastDigit;
                num /= 10;
            }
            return sumDigits % 7 == 0; // gets the sum of all the digits and checks if they are divisible by 7
        }
        static bool ContainsEvenDigit(int num)
        {
            string numString = num.ToString();
            foreach (var digit in numString)
            {
                if (int.Parse(digit.ToString()) % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }
        static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
