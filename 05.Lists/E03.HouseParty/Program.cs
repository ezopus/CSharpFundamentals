using System;
using System.Collections.Generic;

namespace E03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommand = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();
            for (int i = 0; i < numberOfCommand; i++)
            {
                string[] oneName = Console.ReadLine().Split(' ');

                if (oneName.Length == 3)
                {
                    if (guests.Contains(oneName[0]) == false)
                    {
                        guests.Add(oneName[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{oneName[0]} is already in the list!");
                    }
                }
                else if (oneName.Length == 4)
                {
                    if (guests.Contains(oneName[0]))
                    {
                        guests.Remove(oneName[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{oneName[0]} is not in the list!");
                    }
                }
            }

            foreach (string name in guests)
            {
                Console.WriteLine(name);
            }
        }
    }
}
