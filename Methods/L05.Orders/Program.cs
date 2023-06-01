using System;

namespace L05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());
            TotalSum(input, amount);
        }

        static void TotalSum(string input, int amount)
        {
            double price = 0;
            if (input == "water") price = amount * 1;
            else if (input == "coffee") price = amount * 1.5;
            else if (input == "coke") price = amount * 1.4;
            else if (input == "snacks") price = amount * 2;
            Console.WriteLine($"{price:f2}");
        }
    }
}
