using System;

namespace L01.DeclaringInvoking
{
    internal class Program
    {
        static void NumberState(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            NumberState(number);
        }
    }
}
