using System;
using System.Linq;

namespace E09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            while ((input = Console.ReadLine()) != "END")
            {
                Console.WriteLine(IsPalindrome(input).ToString().ToLower());
            }
        }

        private static bool IsPalindrome(string input)
        {
            char[] reversedArray = input.ToCharArray();
            Array.Reverse(reversedArray);
            string reversed = string.Join("", reversedArray);
            return input == reversed;
        }
    }
}
