using System;
using System.Collections.Generic;
using System.Linq;

namespace L06._List_Manipulation_Basics
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
                    case "Add":
                        numberString.Add(int.Parse(command[1]));
                        break;
                    case "Remove":
                        numberString.Remove(int.Parse(command[1]));
                        break;
                    case "RemoveAt":
                        numberString.RemoveAt(int.Parse(command[1]));
                        break;
                    case "Insert":
                        numberString.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numberString));
        }
    }
}
