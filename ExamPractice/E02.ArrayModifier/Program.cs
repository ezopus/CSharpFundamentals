using System;
using System.Collections.Generic;
using System.Linq;

namespace E02.ArrayModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> initialList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string input = "";
            while ((input = Console.ReadLine()) != "end")
            {
                string[] commands = input.Split(" ");
                switch (commands[0])
                {
                    case "swap":
                        int firstIndex = int.Parse(commands[1]);
                        int secondIndex = int.Parse(commands[2]);
                        initialList = SwapIndexes(initialList, firstIndex, secondIndex);
                        break;
                    case "multiply":
                        firstIndex = int.Parse(commands[1]);
                        secondIndex = int.Parse(commands[2]);
                        initialList = MultiplyIndexes(initialList, firstIndex, secondIndex);
                        break;
                    case "decrease":
                        DecreaseElements(initialList);
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", initialList));
        }

        private static List<int> DecreaseElements(List<int> initialList)
        {
            for (int i = 0; i < initialList.Count; i++)
            {
                initialList[i] -= 1;
            }
            return initialList;
        }

        private static List<int> MultiplyIndexes(List<int> initialList, int firstIndex, int secondIndex)
        {
            int multiplied = initialList[firstIndex] * initialList[secondIndex];
            initialList[firstIndex] = multiplied;
            return initialList;
        }

        private static List<int> SwapIndexes(List<int> initialList, int firstIndex, int secondIndex)
        {
            int tempElement = initialList[firstIndex];
            initialList[firstIndex] = initialList[secondIndex];
            initialList[secondIndex] = tempElement;
            return initialList;
        }
    }
}
