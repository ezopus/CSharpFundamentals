using System;
using System.Collections.Generic;
using System.Linq;

namespace M04.MixedUpLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstString = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> secondString = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> newList = new List<int>();

            int startRange = 0;
            int endRange = 0;
            int totalCount = 0;

            if (firstString.Count > secondString.Count)
            {
                startRange = Math.Min(firstString[firstString.Count - 2], firstString[firstString.Count - 1]);
                endRange = Math.Max(firstString[firstString.Count - 2], firstString[firstString.Count - 1]);
                totalCount = secondString.Count;
                firstString.RemoveRange(firstString.Count - 2, 2);
            }
            else
            {
                startRange = Math.Min(secondString[0], secondString[1]);
                endRange = Math.Max(secondString[0], secondString[1]);
                totalCount = firstString.Count;
                secondString.RemoveRange(0, 2);
            }

            for (int i = 0; i < totalCount; i++)
            {
                int first = firstString[i];
                int second = secondString[secondString.Count - 1 - i];
                if (first > startRange && first < endRange) 
                {
                    newList.Add(first);
                }

                if (second > startRange && second < endRange)
                {
                    newList.Add(second);
                }
            }
            newList.Sort();
            Console.WriteLine(string.Join(' ', newList));
        }
    }
}
