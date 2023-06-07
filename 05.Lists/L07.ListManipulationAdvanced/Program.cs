using System;
using System.Collections.Generic;
using System.Linq;

namespace L07.ListManipulationAdvanced
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
            bool isChanged = false;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();
                switch (command[0])
                {
                    case "Add":
                        numberString.Add(int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "Remove":
                        numberString.Remove(int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "RemoveAt":
                        numberString.RemoveAt(int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "Insert":
                        numberString.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "Contains":
                        ContainsNumber(numberString, command);
                        break;
                    case "PrintEven":
                        PrintEven(numberString);
                        break;
                    case "PrintOdd":
                        PrintOdd(numberString);
                        break;
                    case "GetSum":
                        GetSum(numberString);
                        break;
                    case "Filter":
                        string condition = command[1];
                        int filterNumber = int.Parse(command[2]);
                        Filter(numberString, condition, filterNumber);
                        break;
                    default:
                        break;
                }
            }

            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", numberString));
            }
        }
        static void Filter(List<int> numberString, string condition, int filterNumber)
        {
            string filteredString = "";
            switch (condition)
            {
                case ">":
                    foreach (int number in numberString)
                    {
                        if (number > filterNumber)
                        {
                            filteredString += number + " ";
                        }
                    }

                    break;

                case "<":
                    foreach (int number in numberString)
                    {
                        if (number < filterNumber)
                        {
                            filteredString += number + " ";
                        }
                    }

                    break;

                case ">=":
                    foreach (int number in numberString)
                    {
                        if (number >= filterNumber)
                        {
                            filteredString += number + " ";
                        }
                    }

                    break;

                case "<=":
                    foreach (int number in numberString)
                    {
                        if (number <= filterNumber)
                        {
                            filteredString += number + " ";
                        }
                    }

                    break;
            }

            Console.WriteLine(filteredString.Trim(' '));
        }

        static void GetSum(List<int> numberString)
        {
            int sum = 0;
            foreach (int number in numberString)
            {
                sum += number;
            }

            Console.WriteLine(sum);
        }

        static void ContainsNumber(List<int> numberString, string[] command)
        {
            if (numberString.Contains(int.Parse(command[1])))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }

        static void PrintEven(List<int> numberString)
        {
            string evenNums = "";
            foreach (int number in numberString)
            {
                if (number % 2 == 0)
                {
                    evenNums += number + " ";
                }
            }

            Console.WriteLine(evenNums);
        }

        static void PrintOdd(List<int> numberString)
        {
            string oddNums = "";
            foreach (int number in numberString)
            {
                if (number % 2 != 0)
                {
                    oddNums += number + " ";
                }
            }

            Console.WriteLine(oddNums);
        }
    }

}
