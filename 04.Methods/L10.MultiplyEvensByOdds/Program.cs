using System;

namespace L10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int a = GetSumOfEvenDigits(input);
            int b = GetSumOfOddDigits(input);
            Console.WriteLine(GetMultipleOfEvenAndOdds(a, b));
        }

        static int GetMultipleOfEvenAndOdds(int even, int odd)
        {
            return even * odd;
        }

        static int GetSumOfEvenDigits(int input)
        {
            int sum = 0;
            while (input != 0)
            {
                int digit = input % 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
                input /= 10;
            }
            return sum;
        }

        static int GetSumOfOddDigits(int input)
        {
            int sum = 0;
            while (input != 0)
            {
                int digit = input % 10;
                if (digit % 2 != 0)
                {
                    sum += digit;
                }
                input /= 10;
            }
            return sum;
        }
    }
}
