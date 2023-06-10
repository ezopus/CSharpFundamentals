using System;
using System.Collections.Generic;
using System.Linq;

namespace M02.CarRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> totalNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            double sumFirst = 0;
            double sumSecond = 0;

            for (int i = 0; i < totalNumbers.Count / 2; i++)
            {
                if (totalNumbers[i] == 0)
                {
                    sumFirst *= 0.8;
                }
                else
                {
                    sumFirst += totalNumbers[i];
                }
            }

            for (int i = totalNumbers.Count - 1; i > totalNumbers.Count / 2; i--)
            {
                if (totalNumbers[i] == 0)
                {
                    sumSecond *= 0.8;
                }
                else
                {
                    sumSecond += totalNumbers[i];
                }
            }

            if (sumFirst < sumSecond)
            {
                Console.WriteLine($"The winner is left with total time: {Math.Round(sumFirst, 2)}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {Math.Round(sumSecond, 2)}");
            }

        }
    }
}
