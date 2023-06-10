using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace E04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberString = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string input = "";
            while ((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split(' ');
                switch (command[0])
                {
                    case "Add":
                        int number = int.Parse(command[1]);
                        AddNumber(numberString, number);
                        break;
                    case "Insert":
                        int insertNumber = int.Parse(command[1]);
                        int insertIndex = int.Parse(command[2]);
                        InsertNumber(numberString, insertNumber, insertIndex);
                        break;
                    case "Remove":
                        int index = int.Parse(command[1]);
                        RemoveAtIndex(numberString, index);
                        break;
                    case "Shift":
                        int count = int.Parse(command[2]);
                        if (command[1] == "left")
                        {
                            numberString = ShiftLeft(numberString, count);
                        }
                        else if (command[1] == "right")
                        {
                            numberString = ShiftRight(numberString, count);
                        }
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numberString));
        }

        private static List<int> ShiftRight(List<int> numberString, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int lastNumber = numberString[numberString.Count - 1];
                numberString.Insert(0, lastNumber);
                numberString.RemoveAt(numberString.Count - 1);
            }
            return numberString;
        }

        private static List<int> ShiftLeft(List<int> numberString, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int firstNumber = numberString[0];
                numberString.Add(firstNumber);
                numberString.RemoveAt(0);
            }
            return numberString;
        }

        private static void RemoveAtIndex(List<int> numberString, int index)
        {
            if (index >= numberString.Count || index < 0)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            numberString.RemoveAt(index);
        }

        private static void InsertNumber(List<int> numberString, int insertNumber, int insertIndex)
        {
            if (insertIndex >= numberString.Count || insertIndex < 0)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            numberString.Insert(insertIndex, insertNumber);
        }

        private static void AddNumber(List<int> numberString, int number)
        {
            numberString.Add(number);
        }


    }
}
