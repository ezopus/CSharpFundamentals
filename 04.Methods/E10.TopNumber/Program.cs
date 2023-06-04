using System;

namespace E10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            IsTopNumber(number);
        }

        private static void IsTopNumber(int number)
        {
            for (int i = 0; i <= number; i++)
            {
                if (SumOfDigits(i) && OneOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool OneOddDigit(int number)
        {
            while (number != 0)
            {
                if ((number % 10) % 2 != 0)
                {
                    return true;
                }
                number /= 10;
            }
            return false;

        }

        private static bool SumOfDigits(int number)
        {
            int sumOfDigits = 0;
            while (number != 0)
            {
                sumOfDigits += number % 10;
                number /= 10;
            }

            if (sumOfDigits % 8 == 0)
            {
                return true;
            }
            return false;
        }

    }
}
