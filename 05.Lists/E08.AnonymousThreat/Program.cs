using System;
using System.Collections.Generic;
using System.Linq;

namespace E08.AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> initialList = Console.ReadLine()
                .Split(' ')
                .ToList();
            string input = "";
            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] command = input.Split(' ');

                if (command[0] == "merge")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    initialList = MergeElements(initialList, startIndex, endIndex);
                }
                else if (command[0] == "divide")
                {
                    int index = int.Parse(command[1]);
                    int partitionSize = int.Parse(command[2]);
                    initialList = DivideIntoPartitions(initialList, index, partitionSize);
                }
            }

            Console.WriteLine(string.Join(' ', initialList));

        }
        static List<string> MergeElements(List<string> initialList, int startIndex, int endIndex)
        {
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            if (endIndex >= initialList.Count)
            {
                endIndex = initialList.Count - 1;
            }

            if (startIndex < initialList.Count)
            {
                string temp = "";
                for (int i = startIndex; i <= endIndex; i++)
                {
                    temp += initialList[i];
                }

                int rangeLength = endIndex - startIndex + 1;
                initialList.RemoveRange(startIndex, rangeLength);
                initialList.Insert(startIndex, temp);
            }

            return initialList;
        }
        static List<string> DivideIntoPartitions(List<string> initialList, int index, int partitionCount)
        {
            string tempString = initialList[index];
            int partitionSize = tempString.Length / partitionCount;
            int remainder = tempString.Length % partitionCount;
            List<string> splitList = new List<string>();

            initialList.RemoveAt(index);

            int newPartitionIndex = 0;
            while (partitionCount > 0)
            {
                splitList.Add(tempString.Substring(newPartitionIndex, partitionSize));
                partitionCount--;
                newPartitionIndex += partitionSize;
            }

            if (remainder != 0)
            {
                splitList[splitList.Count - 1] += tempString[tempString.Length - 1];
            }
            initialList.InsertRange(index, splitList);
            return initialList;
        }
    }
}
