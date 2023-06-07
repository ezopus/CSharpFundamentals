using System;
using System.Collections.Generic;
using System.Linq;

namespace L05.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberString = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> resultList = new List<int>();

            foreach (int number in numberString)
            {
                if (number >= 0)
                {
                    resultList.Add(number);
                }
            }

            resultList.Reverse();

            if (resultList.Count != 0)
            {
                Console.WriteLine(string.Join(" ", resultList));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
