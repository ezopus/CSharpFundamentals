using System;
using System.Collections.Generic;
using System.Linq;

namespace L01.SumAdjacentEqualNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numberString = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToList();
            
            for (int i = 0; i < numberString.Count - 1; i++)
            {
                if (numberString[i] == numberString[i + 1])
                {
                    numberString[i] += numberString[i + 1];
                    numberString.RemoveAt(i + 1);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ", numberString));

        }
    }
}
