using System;

namespace E06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintMiddleChar(input);
        }

        private static void PrintMiddleChar(string input)
        {
            string middleChar = "";
            if (input.Length % 2 == 0)
            {
                middleChar = input[input.Length / 2 - 1] + input[input.Length / 2].ToString();
            }
            else
            {
                middleChar = input[input.Length / 2].ToString();
            }

            Console.WriteLine(middleChar);
        }
    }
}
