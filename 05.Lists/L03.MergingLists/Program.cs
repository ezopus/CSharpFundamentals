using System;
using System.Collections.Generic;
using System.Linq;

namespace L03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().
                Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> secondList = Console.ReadLine().
                Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> mergedList = new List<int>();

            for (int i = 0; i < Math.Max(firstList.Count, secondList.Count); i++)
            {
                if (i < firstList.Count)
                {
                    mergedList.Add(firstList[i]);

                }
                if (i < secondList.Count)
                {
                    mergedList.Add(secondList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", mergedList));

        }
    }
}
