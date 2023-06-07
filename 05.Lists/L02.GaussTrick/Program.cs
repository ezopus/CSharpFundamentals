using System;
using System.Collections.Generic;
using System.Linq;

namespace L02.GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberString = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();

            for (int i = 0; i < numberString.Count / 2; i++)
            {
                result.Add(numberString[i] + numberString[numberString.Count - 1 - i]);
            }

            if (numberString.Count % 2 != 0)
            {
                result.Add(numberString[numberString.Count / 2]);
            }

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
