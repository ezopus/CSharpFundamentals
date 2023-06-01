using System;

namespace L11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            Console.WriteLine(Operation(numberOne, operation, numberTwo));
        }

        static double Operation(double a, char @operator, double b)
        {
            double result = 0;
            if (@operator == '/' && b != 0)
            {
                result = a / b;
            }
            else if (@operator == '*')
            {
                result = a * b;
            }
            else if (@operator == '+')
            {
                result = a + b;
            }
            else if (@operator == '-')
            {
                result = a - b;
            }
            return result;
        }
    }
}
