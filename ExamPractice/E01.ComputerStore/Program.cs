using System;
using System.Collections.Generic;

namespace E01.ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> parts = new List<double>();
            string input = "";
            while (true)
            {
                input = Console.ReadLine();
                if (input == "special" || input == "regular")
                {
                    break;
                }
                double item = double.Parse(input);
                if (item < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                parts.Add(double.Parse(input));
            }

            var totalSum = TotalSumWithoutTaxes(parts);
            PrintReceipt(totalSum, input);
        }

        static void PrintReceipt(double totalSum, string input)
        {
            if (totalSum == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            else
            {
                double totalNoTaxes = totalSum;
                double taxes = totalSum * 0.2;
                totalSum = totalNoTaxes + taxes;
                if (input == "special")
                {
                    totalSum *= (1 - 0.1);
                }
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalNoTaxes:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalSum:f2}$");
            }
        }

        static double TotalSumWithoutTaxes(List<double> parts)
        {
            double totalSum = 0;
            foreach (double item in parts)
            {
                totalSum += item;
            }

            return totalSum;
        }
    }
}
