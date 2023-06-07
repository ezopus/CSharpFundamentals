using System;
using System.Collections.Generic;
using System.Linq;

namespace E02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberString = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            string input = "";
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                switch (command[0])
                {
                    case "Delete":
                        int deleteElement = int.Parse(command[1]);
                        DeleteElement(numberString, deleteElement);
                        break;
                    case "Insert":
                        int element = int.Parse(command[1]);
                        int position = int.Parse(command[2]);
                        InsertElement(numberString, element, position);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numberString));
        }

        private static void InsertElement(List<int> numberString, int element, int position)
        {
            numberString.Insert(position,element);
        }

        private static void DeleteElement(List<int> numberString,int deleteElement)
        {
            for (int i = 0; i < numberString.Count; i++)
            {
                if (numberString[i] == deleteElement)
                {
                    numberString.RemoveAt(i);
                }
            }
        }
    }
}
