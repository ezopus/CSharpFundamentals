using System;
using System.Collections.Generic;
using System.Linq;

namespace E05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberString = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int[] bombString = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int bombNumber = bombString[0];
            int power = bombString[1];
            List<int> bombIndex = new List<int>();

            numberString = RemoveBombNumbers(numberString, bombNumber, bombIndex, power);

            Console.WriteLine(SumRemainingNumbers(numberString));
        }

        static List<int> RemoveBombNumbers(List<int> numberString, int bombNumber, List<int> bombIndex, int power)
        {
            while (numberString.Contains(bombNumber))
            {
                int index = numberString.IndexOf(bombNumber);
                int leftIndex = Math.Max(0, index - power);
                int rightIndex = Math.Min(numberString.Count - 1, index + power);

                int rangeLength = rightIndex - leftIndex + 1;

                numberString.RemoveRange(leftIndex, rangeLength);
            }
            return numberString;
        }

        static int SumRemainingNumbers(List<int> numberString)
        {
            int remainingSum = 0;
            foreach (int number in numberString)
            {
                remainingSum += number;
            }

            return remainingSum;
        }
    }
}
