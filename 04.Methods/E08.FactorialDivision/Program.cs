using System;

namespace E08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            DivideFactorials(firstNumber, secondNumber);
        }

        private static void DivideFactorials(double firstNumber, double secondNumber)
        {
            double firstFactorial = 1;
            double secondFactorial = 1;
            for (int i = 1; i <= firstNumber; i++)
            {
                firstFactorial *= i;
            }

            for (int i = 1; i <= secondNumber; i++)
            {
                secondFactorial *= i;
            }
            Console.WriteLine($"{firstFactorial / secondFactorial:F2}");
        }
    }
}
